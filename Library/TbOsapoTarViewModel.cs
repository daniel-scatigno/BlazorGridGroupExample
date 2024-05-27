using System;
using System.Collections.Generic;
using Microsoft.Extensions.Localization;

namespace BlazorGridGroupExample.Library;

public partial class TbOsapoTarViewModel
{
   public int CdTar { get; set; }

   public string DeTar { get; set; } = null!;

   public string? DeMottar { get; set; }
}

