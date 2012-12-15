using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Retorno
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retConsReciNFe
    {
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        /// Identificação do Ambiente: 
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Versão do Aplicativo que recebeu o Lote. A versão deve ser iniciada 
        /// com a sigla da UF nos casos de WS próprio ou a sigla SCAN, SVAN ou 
        /// SVRS nos demais casos.
        /// </summary>
        [XmlElement]
        public string verAplic { get; set; }

        /// <summary>
        /// Número do Recibo consultado. Será
        /// preenchido com zeros se for impossível de
        /// obter o valor da mensagem de entrada (Ex. mensagem inválida).
        /// </summary>
        [XmlElement]
        public string nRec { get; set; }

        /// <summary>
        /// Código do status da resposta para o Lote (vide item 5.1.1)
        /// Se cStatus = 215, 516, 517 ou 545 significa
        /// que a mensagem de consulta é inválida.
        /// Se cStatus = 225, 565. 567 ou 568, significa
        /// que o lote de NF-e consultado é inválido
        /// </summary>
        [XmlElement]
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status da resposta
        /// </summary>
        [XmlElement]
        public string xMotivo { get; set; }

        /// <summary>
        /// Código da UF que atendeu a solicitação.
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Código da Mensagem (v2.0) Campo de uso da
        /// SEFAZ para enviar mensagem de interesse da
        /// SEFAZ para o emissor.
        /// </summary>
        [XmlElement]
        public string cMsg { get; set; }

        /// <summary>
        /// Mensagem da SEFAZ para o emissor. (v2.0)
        /// </summary>
        [XmlElement]
        public string xMsg { get; set; }

        /// <summary>
        /// Conjunto de resultado do processamento de
        /// cada NF-e (vide leiaute abaixo).
        /// Estas informações são retornadas apenas para
        /// o código do status do lote = 104 (Lote
        /// processado)
        /// </summary>
        [XmlElement]
        public Reyx.Nfe.Schema200.protNFe protNFe { get; set; }
    }
}