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
    /// <summary>
	/// 
	/// </summary>
	public class veicProd
    {
        /// <summary>
        /// Tipo da operação
        /// <para>1 – Venda concessionária</para>
        /// <para>2 – Faturamento direto para consumidor final</para>
        /// <para>3 – Venda direta para grandes consumidores (frotista, governo, ...)</para>
        /// <para>0 – Outros</para>
        /// </summary>
        [XmlElement]
        public string tpOp { get; set; }

        /// <summary>
        /// Chassi do veículo
        /// </summary>
        [XmlElement]
        public string chassi { get; set; }

        /// <summary>
        /// Cor (código de cada montadora)
        /// </summary>
        [XmlElement]
        public string cCor { get; set; }

        /// <summary>
        /// Descrição da Cor
        /// </summary>
        [XmlElement]
        public string xCor { get; set; }

        /// <summary>
        /// Potência Motor (CV)
        /// </summary>
        [XmlElement]
        public string pot { get; set; }

        /// <summary>
        /// Cilindradas
        /// </summary>
        [XmlElement]
        public string cilin { get; set; }

        /// <summary>
        /// Peso Líquido
        /// </summary>
        [XmlElement]
        public string pesoL { get; set; }

        /// <summary>
        /// Peso Bruto
        /// </summary>
        [XmlElement]
        public string pesoB { get; set; }

        /// <summary>
        /// Serial (série)
        /// </summary>
        [XmlElement]
        public string nSerie { get; set; }

        /// <summary>
        /// Tipo de combustível (Tabela RENAVAN)
        /// </summary>
        [XmlElement]
        public string tpComb { get; set; }

        /// <summary>
        /// Número de Motor
        /// </summary>
        [XmlElement]
        public string nMotor { get; set; }

        /// <summary>
        /// Capacidade Máxima de Tração
        /// </summary>
        [XmlElement]
        public string CMT { get; set; }

        /// <summary>
        /// Distância entre eixos
        /// </summary>
        [XmlElement]
        public string dist { get; set; }

        /// <summary>
        /// Ano Modelo de Fabricação
        /// </summary>
        [XmlElement]
        public string anoMod { get; set; }

        /// <summary>
        /// Ano de Fabricação
        /// </summary>
        [XmlElement]
        public string anoFab { get; set; }

        /// <summary>
        /// Tipo de Pintura
        /// </summary>
        [XmlElement]
        public string tpPint { get; set; }

        /// <summary>
        /// Tipo de Veículo (Tabela RENAVAN)
        /// </summary>
        [XmlElement]
        public string tpVeic { get; set; }

        /// <summary>
        /// Espécie de Veículo (Tabela RENAVAN)
        /// </summary>
        [XmlElement]
        public string espVeic { get; set; }

        /// <summary>
        /// Condição do VIN
        /// </summary>
        [XmlElement]
        public string VIN { get; set; }

        /// <summary>
        /// Condição do Veículo
        /// <para>1 - Acabado</para>
        /// <para>2 - Inacabado</para>
        /// <para>2 - Semi-acabado</para>
        /// </summary>
        [XmlElement]
        public string condVeic { get; set; }

        /// <summary>
        /// Código Marca Modelo (Tabela RENAVAN)
        /// </summary>
        [XmlElement]
        public string cMod { get; set; }

        /// <summary>
        /// Código da Cor (Tabela RENAVAN)
        /// </summary>
        [XmlElement]
        public string cCorDENATRAN { get; set; }

        /// <summary>
        /// Capacidade máxima de lotação
        /// </summary>
        [XmlElement]
        public string lota { get; set; }

        /// <summary>
        /// Restrição
        /// <para>0 - Não há</para>
        /// <para>1 - Alienação Fiduciária</para>
        /// <para>2 - Arrendamento Mercantil</para>
        /// <para>3 - Reserva de Domínio</para>
        /// <para>4 - Penhor de Veículos</para>
        /// <para>9 - outras.</para>
        /// </summary>
        [XmlElement]
        public string tpRest { get; set; }
    }
}
