using System;
using System.Collections.Generic;

using Microsoft.Extensions.Localization;

namespace BlazorGridGroupExample.Library;

public partial class ClienteViewModel
{
	public int Id { get; set; }

	public string? NmClisis { get; set; }

	public string? DeEndclisis { get; set; } = "";

	public string? NmCttclisis { get; set; } = "";

	public string? NuTelclisis { get; set; }= "";

	public string? DeEmaclisis { get; set; } = "";

	public DateTime? DtInipro { get; set; }

	public DateTime? DtFimpre { get; set; }

	public DateTime? DtFimpro { get; set; }

	public string? FlSta { get; set; } = "";

	public short? QtMaq { get; set; }

	public string? NmLogin { get; set; }

	public string? DeSenha { get; set; }

	public string? SnAcerem { get; set; }

	public string? SnTerser { get; set; }

	public string? NmServidor { get; set; }

	public string? NmOdbc { get; set; }

	public string? NmDtbclisis { get; set; }

	public string? NmDtbesc { get; set; }

	public short? CDClisisnc { get; set; }

	public string? SnExt { get; set; }

	public string? SnCab { get; set; }

	public string? FlSup { get; set; }

	public string? SnOut { get; set; }

	public string? Ativo { get; set; }

	public bool Parceiro { get; set; }

	public bool AprovacaoOutSourcing { get; set; }

	public bool AprovacaoHelpdesk { get; set; } = true;

	public bool AprovacaoTesteSistema { get; set; } = true;



}
