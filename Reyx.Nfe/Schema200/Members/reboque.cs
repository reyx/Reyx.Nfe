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
	public class reboque
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string placa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string UF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string RNTC { get; set; }
    }
}
