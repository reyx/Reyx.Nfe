using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
	/// 
	/// </summary>
	public class ide
    {
        /// <summary>
        /// Código da UF do emitente do Documento Fiscal. 
        /// Utilizar a Tabela do IBGE de código de
        /// unidades da federação (Anexo IV - Tabela de UF, 
        /// Município e País).
        /// </summary>
        [XmlElement]
        public string cUF { get; set; }

        /// <summary>
        /// Chave de Acesso. Número aleatório gerado pelo emitente
        /// para cada NF-e para evitar acessos indevidos da NF-e. (v2.0)
        /// </summary>
        [XmlElement]
        public string cNF { get; set; }

        /// <summary>
        /// Descrição da Natureza da Operação
        /// <para>
        ///     Informar a natureza da operação de que decorrer a
        ///     saída ou a entrada, tais como: venda, compra, 
        ///     transferência, devolução, importação, consignação,
        ///     remessa (para fins de demonstração, de 
        ///     industrialização ou outra), conforme previsto na
        ///     alínea 'i', inciso I, art. 19 do CONVÊNIO S/Nº, 
        ///     de 15 de dezembro de 1970.
        /// </para>
        /// </summary>
        [XmlElement]
        public string natOp { get; set; }

        /// <summary>
        /// Indicador da forma de pagamento
        /// <para>0 – pagamento à vista</para>
        /// <para>1 – pagamento à prazo</para>
        /// <para>2 - outros</para>
        /// </summary>
        [XmlElement]
        public string indPag { get; set; }

        /// <summary>
        /// Código do Modelo do Documento Fiscal
        /// <para>
        ///     identificação da NF-e, emitida
        ///     em substituição ao modelo 1 ou 1A.
        /// </para>
        /// </summary>
        [XmlElement]
        public string mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal
        /// <para>
        ///     Preencher com zeros na hipótese de a NF-e 
        ///     não possuir série. (v2.0) 
        /// </para>
        /// <para>
        ///     Série 890-899 de uso exclusivo para emissão de 
        ///     NF-e avulsa, pelo contribuinte com seu certificado 
        ///     digital,  através do site do Fisco (procEmi=2). (v2.0)
        /// </para>
        /// <para>
        ///     Serie 900-999 – uso exclusivo de NF-e emitidas 
        ///     no SCAN. (v2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public string serie { get; set; }

        /// <summary>
        /// Número do Documento Fiscal
        /// </summary>
        [XmlElement]
        public string nNF { get; set; }

        /// <summary>
        /// Data de emissão do Documento Fiscal
        /// <para>Formato “AAAA-MM-DD”</para>
        /// </summary>
        [XmlElement]
        public string dEmi { get; set; }

        /// <summary>
        /// Data de Saída ou da Entrada da Mercadoria/Produto
        /// <para>Formato "AAAA-MM-DD"</para>
        /// </summary>
        [XmlElement]
        public string dSaiEnt { get; set; }

        /// <summary>
        /// Hora de Saída ou da Entrada da Mercadoria/Produto
        /// <para>Formato "HH:MM:SS" (v.2.0)</para>
        /// </summary>
        [XmlElement]
        public string hSaiEnt { get; set; }

        /// <summary>
        /// Tipo de Operação
        /// <para>0-entrada</para>
        /// <para>1-saída</para>
        /// </summary>
        [XmlElement]
        public string tpNF { get; set; }

        /// <summary>
        /// Código do Município de
        /// <para>
        ///     Informar o município de Ocorrência do 
        ///     Fato Gerador ocorrência do fato gerador do
        ///     ICMS. Utilizar a Tabela do IBGE (Anexo VII - 
        ///     Tabela de UF, Município e País)
        /// </para>
        /// </summary>
        [XmlElement]
        public string cMunFG { get; set; }

        /// <summary>
        /// Grupo de informação das NF/NF-e referenciadas
        /// <para>
        ///     Grupo com as informações das NF/NF-e 
        ///     /NF de produtor/ Cupom Fiscal referenciadas.
        ///     Esta informação será utilizada nas hipóteses 
        ///     previstas na legislação. (Ex.: Devolução de
        ///     Mercadorias, Substituição de NF cancelada, 
        ///     Complementação de NF, etc.). (v.2.0)
        /// </para>
        /// </summary>
        [XmlElement]
        public List<Reyx.Nfe.Schema200.Members.NFref> NFref { get; set; }

        /// <summary>
        /// Formato de Impressão do DANFE
        /// <para>1 - Retrato</para>
        /// <para>2 - Paisagem</para>
        /// </summary>
        [XmlElement]
        public string tpImp { get; set; }

        /// <summary>
        /// Tipo de Emissão da NF-e
        /// <para>1 – Normal – emissão normal</para>
        /// <para>
        ///     2 – Contingência FS – emissão em contingência 
        ///     com impressão do DANFE em Formulário de Segurança
        /// </para>
        /// <para>
        ///     3 – Contingência SCAN – emissão em contingência 
        ///     no Sistema de Contingência do Ambiente Nacional – SCAN;
        /// </para>
        /// <para>
        ///     4 – Contingência DPEC - emissão em contingência com
        ///     envio da Declaração Prévia de Emissão em Contingência –
        ///     DPEC;
        /// </para>
        /// <para>
        ///     5 – Contingência FS-DA - emissão em contingência com
        ///     impressão do DANFE em Formulário de Segurança para
        ///     Impressão de Documento Auxiliar de Documento Fiscal
        ///     Eletrônico (FS-DA).
        /// </para>
        /// </summary>
        [XmlElement]
        public string tpEmis { get; set; }

        /// <summary>
        /// Dígito Verificador da Chave de Acesso da NF-e
        /// <para>
        ///     Informar o DV da Chave de Acesso da NF-e, 
        ///     o DV será calculado com a aplicação do 
        ///     algoritmo módulo 11 (base 2,9) da Chave de 
        ///     Acesso. (vide item 5 do Manual de Integração)
        /// </para>
        /// </summary>
        [XmlElement]
        public string cDV { get; set; }

        /// <summary>
        /// Identificação do Ambiente
        /// <para>1 - Produção</para>
        /// <para>2 - Homologação</para>
        /// </summary>
        [XmlElement]
        public string tpAmb { get; set; }

        /// <summary>
        /// Finalidade de emissão da NFe
        /// <para>1 - NF-e normal</para>
        /// <para>2 - NF-e complementar</para>
        /// <para>3 - NF-e de ajuste</para>
        /// </summary>
        [XmlElement]
        public string finNFe { get; set; }

        /// <summary>
        /// Processo de emissão da NF-e
        /// <para>
        ///     0 - emissão de NF-e com aplicativo do contribuinte
        /// </para>
        /// <para>
        ///     1 - emissão de NF-e avulsa pelo Fisco
        /// </para>
        /// <para>
        ///     2 - emissão de NF-e avulsa, pelo contribuinte com 
        ///     seu certificado digital, através do site do Fisco
        /// </para>
        /// <para>
        ///     3- emissão NF-e pelo contribuinte com aplicativo 
        ///     fornecido pelo Fisco.
        /// </para>
        /// </summary>
        [XmlElement]
        public string procEmi { get; set; }

        /// <summary>
        /// Versão do Processo de emissão da NF-e
        /// </summary>
        [XmlElement]
        public string verProc { get; set; }

        /// <summary>
        /// Data e Hora da entrada em contingência no 
        /// formato AAAA-MMDDTHH:MM:SS
        /// </summary>
        [XmlElement]
        public string dhCont { get; set; }

        /// <summary>
        /// Justificativa da entrada em contingência
        /// </summary>
        [XmlElement]
        public string xJust { get; set; }
    }
}
