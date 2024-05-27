using System;
using System.Collections.Generic;
using Microsoft.Extensions.Localization;


namespace BlazorGridGroupExample.Library;

public class OSApontamentoViewModel
{
    public long IdApo { get; set; }

    public string CdUsuanalis { get; set; } = null!;

    public int? CdOs { get; set; } = -1;


    public int? CdTar { get; set; } = 1;

    public DateTime? DtApo { get; set; }

    public DateTime? HrIni { get; set; } = DateTime.Now;

    public DateTime? HrFin { get; set; } = DateTime.Now;

    public DateTime? HrDes { get; set; } = new DateTime(1900, 1, 1, 0, 0, 0);

    public DateTime HrApl { get; set; } = new DateTime(1900, 1, 1, 0, 0, 0);

    public Int64 HorasAplicadas
    {
        get
        {
            return HrApl.TimeOfDay.Ticks;
        }
    }

    public TimeSpan HorasAplicadasSpan { get { return HrApl.TimeOfDay; } }


    public DateTime HrAplTratada => TratarHrApl();
    public string HrAplTratadaStr => HrAplTratada.ToString("HH:mm");

    private DateTime TratarHrApl()
    {
        try
        {
            if (HrIni == null)
                HrIni = new DateTime(1900, 1, 1, 0, 0, 0);
            if (HrFin == null)
                HrFin = new DateTime(1900, 1, 1, 0, 0, 0);
            if (HrDes == null)
                HrDes = new DateTime(1900, 1, 1, 0, 0, 0);

            var dateapl = new DateTime(1900, 1, 1, 0, 0, 0);
            var totalHours = Convert.ToInt32((HrFin.Value - HrIni.Value).Hours);
            dateapl = dateapl.AddHours(totalHours);
            var totalMinutes = Convert.ToInt32((HrFin.Value - HrIni.Value).Minutes);
            dateapl = dateapl.AddMinutes(totalMinutes);

            dateapl = dateapl.AddMinutes(-(HrDes.Value.Hour * 60 + HrDes.Value.Minute));
            return dateapl;
        }
        catch (Exception ex)
        {
            return new DateTime(1900, 1, 1, 0, 0, 0);
        }
    }

    public string? DeObs { get; set; }

    public short? CdSta { get; set; }

    public DateTime? DtLck { get; set; }

    public string? DeObspri { get; set; }

    public int? CdClisis { get; set; } = 0;

    public int? CdOspro { get; set; }

    public bool? FlEnviadoemailatualizacao { get; set; }

    public int? CdEvento { get; set; }

    public string? Custo { get; set; }

    public int? CdClisisparceiro { get; set; }
    public ClienteViewModel CdClisisparceiroNavigation { get; set; }
    public TbOsapoTarViewModel? CdTarNavigation { get; set; }

    public OSViewModel? OrdemServico { get; set; }

    public bool BaixarOs { get; set; }
    public string MotivoBaixaOS { get; set; }

    public int? IdCusto { get; set; }

    #region Filtros
    public DateTime? DataInicial { get; set; }
    public DateTime? DataFinal { get; set; }
    public string? UsuarioAnalista { get; set; }
    public int? IdCliente { get; set; }
    #endregion

}
