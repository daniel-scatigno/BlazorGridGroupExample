using System.Collections;
using System.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata;
using System.Data.Common;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;



namespace BlazorGridGroupExample.Components
{
   public delegate Task DeleteActionDelegate(object id);

   public partial class ServiceDataAdaptorComponent<TModel> : DataAdaptor<TModel> where TModel : class
   {
      [Parameter]
      [JsonIgnore]
      public RenderFragment ChildContent { get; set; }

      protected JsonSerializerOptions JsonOptions { get; set; }

      [Parameter]
      public EventCallback<List<TModel>> DataRead { get; set; }


      public DataResult DataResult { get; set; }

      [Parameter]
      public List<string> IncludeFields { get; set; }

      public ServiceDataAdaptorComponent() : base()
      {
         JsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
         JsonOptions.ReferenceHandler = ReferenceHandler.Preserve;
      }
      protected override async Task OnInitializedAsync()
      {
         //Important, necessário para carregar os dados
         await base.OnInitializedAsync();
      }

      public override async Task<object> ReadAsync(DataManagerRequest dm, string key = null)
      {
         dm.ServerSideGroup = false;


         if (IncludeFields != null && IncludeFields.Any())
            dm.Select = IncludeFields;


         //Executa o reader usando um DynamicQuery ou DataManagerRequest
         var dir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory;
         string jsonDataFromFile = File.ReadAllText($"{dir.FullName}\\Library\\teste.json");
         var result = JsonSerializer.Deserialize<List<TModel>>(jsonDataFromFile, JsonOptions)
            .ToList();
         result = Syncfusion.Blazor.DataOperations.PerformFiltering(result, dm.Where, "and").ToList();
         int count = result.Count();



         if (dm.Group != null)
            result = result.OrderBy(x => dm.Group[0]).ToList();
         if (dm.Take > 0)
            result = result.Skip(dm.Skip).Take(dm.Take).ToList();


         DataResult = new DataResult()
         {
            Result = result,
            Count = count
         };

         if (dm.Where != null)
         {
            foreach (var w in dm.Where)
               Console.WriteLine($"WhereFilter: {w.Field}.{w.Operator}.(\"{w.value}\")");
         }

         if (dm.Group != null && !dm.ServerSideGroup)
         {
            IEnumerable GroupData = Enumerable.Empty<object>();
            foreach (var group in dm.Group)
            {
               var groupData = DataUtil.Group<TModel>(DataResult.Result, group, dm.Aggregates, 0, dm.GroupByFormatter);
               DataResult.Result = groupData;

            }

            return dm.RequiresCounts ? DataResult : (object)DataResult.Result;
         }


         Console.WriteLine("RequiredCounts:" + dm.RequiresCounts.ToString());
         Console.WriteLine("Count::" + ((List<TModel>)DataResult.Result).Count());

         return dm.RequiresCounts ? DataResult : (List<TModel>)DataResult.Result;
      }



   }
}