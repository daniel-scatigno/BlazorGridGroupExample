using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Localization;

using System.ComponentModel;

namespace BlazorGridGroupExample.Library;
public class OSViewModel
{
	public int Id { get; set; }

	public int? IdCliente { get; set; }

	public string? CdUsu { get; set; }

	public DateTime? DtIni { get; set; }

	public string? CdUsuautout { get; set; }

	public DateTime? DtUsuautout { get; set; }

	public string? CdUsuautsis { get; set; }

	public DateTime? DtUsuautsis { get; set; }

	public string? CdUsuanalis { get; set; }

	public DateTime? DtUsuanalis { get; set; }

	public string? CdUsutessis { get; set; }

	public DateTime? DtUsutessis { get; set; }

	public string? CdUsutescon { get; set; }

	public DateTime? DtUsutescon { get; set; }

	public string? DeObs { get; set; }


    

    public string? FlPri { get; set; }

	public string? DeObspri { get; set; }

	public string? FlIe { get; set; }

	public string? FlMel { get; set; }

	public int? CdSta { get; set; }
	public object Status { get; set; }
	
	public string? FlSup { get; set; }

	public string? CdUsuhomosis { get; set; }

	public DateTime? DtUsuhomosis { get; set; }

	public int? NuPri { get; set; }

	[DisplayName("OS Reincidente")]
	public int CdOsrec { get; set; }

	public string? CdUsudistri { get; set; }

	public string? CdNivsatis { get; set; }

	public string? DeObssatis { get; set; }

	public string? DeTel { get; set; }

	public string? DeMaq { get; set; }

	public DateTime? DtStatus { get; set; }

	public int? QtDevout { get; set; }

	public int? CdOspro { get; set; }

	public DateTime? DtPreent { get; set; }

	public DateTime? DtPreentinc { get; set; }

	public DateTime? DtInides { get; set; }

	public DateTime? DtInidescri { get; set; }

	public string? CdUsupreent { get; set; }

	public string? DeObspreent { get; set; }

	public string? SnEmapreent { get; set; }

	public int? NuPriori { get; set; }

	public int? QtHsprev { get; set; }

	public string? NuTela { get; set; }

	public string? DeProblema { get; set; }

	public string? DeSolucao { get; set; }

	public int? CdTecnologia { get; set; }

	public int? QtHsprevvnd { get; set; }

	public int? CdEvento { get; set; }

	public bool? BtControlada { get; set; }


	
	public int? IdClassificacao { get; set; }
	public int? IdOSArea { get; set; }
	public int? IdServicoPrestado { get; set; }
	public string DescricaoComposta => $"OS:{Id} / Cliente:{Cliente?.NmClisis}";
	public string Tipo { get; set; } = "Requisição";
	public virtual ClienteViewModel? Cliente { get; set; }

	public IList<OSAcompanhamentoViewModel> OrdemServicoAcompanhamentos { get; set; } = new List<OSAcompanhamentoViewModel>();
	//public virtual OSClassificacao? Classificacao { get; set; }
	//public virtual TbOsSup? Area { get; set; }
	//public virtual Tbtecnologiao? Tecnologia { get; set; }
	//public virtual ICollection<OSObservacao> OrdemServicoObservacoes { get; } = new List<OSObservacao>();
	//public virtual IList<OSApontamento> OrdemServicoApontamentos { get; set; } = null!;

}


