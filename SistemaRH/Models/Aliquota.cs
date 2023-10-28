using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaRH.Models;

public class Aliquota
{
    public Aliquota()
    {
        AliquotaDetalhes = new List<AliquotaDetalhe>();
    }
    
    public int Id { get; set; }

    [Range(0,9999)]
    [DisplayName("Ano de vig�ncia")]
    public int AnoVigencia { get; set; }

    [DisplayName("Descri��o")]
    public string Descricao { get; set; }

    public bool Desconta { get; set; }

    public List<AliquotaDetalhe> AliquotaDetalhes { get; set; }
}