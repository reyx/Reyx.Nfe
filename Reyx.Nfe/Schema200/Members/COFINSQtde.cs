﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Reyx.Nfe.Schema200.Members
{
    /// <summary>
	/// 
	/// </summary>
	public class COFINSQtde
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string qBCProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vAliqProd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string vCOFINS { get; set; }
    }
}
