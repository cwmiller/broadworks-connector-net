using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCrInterfaceGetRequest.
    /// <see cref="SystemCrInterfaceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38709""}]")]
    public class SystemCrInterfaceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _crAuditEnabled;

        [XmlElement(ElementName = "crAuditEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38709")]
        public bool CrAuditEnabled
        {
            get => _crAuditEnabled;
            set
            {
                CrAuditEnabledSpecified = true;
                _crAuditEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditEnabledSpecified { get; set; }

        private int _crAuditIntervalMilliseconds;

        [XmlElement(ElementName = "crAuditIntervalMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38709")]
        [MinInclusive(500)]
        [MaxInclusive(60000)]
        public int CrAuditIntervalMilliseconds
        {
            get => _crAuditIntervalMilliseconds;
            set
            {
                CrAuditIntervalMillisecondsSpecified = true;
                _crAuditIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditIntervalMillisecondsSpecified { get; set; }

        private int _crAuditTimeoutMilliseconds;

        [XmlElement(ElementName = "crAuditTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38709")]
        [MinInclusive(500)]
        [MaxInclusive(10000)]
        public int CrAuditTimeoutMilliseconds
        {
            get => _crAuditTimeoutMilliseconds;
            set
            {
                CrAuditTimeoutMillisecondsSpecified = true;
                _crAuditTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditTimeoutMillisecondsSpecified { get; set; }

        private bool _crConnectionEnabled;

        [XmlElement(ElementName = "crConnectionEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38709")]
        public bool CrConnectionEnabled
        {
            get => _crConnectionEnabled;
            set
            {
                CrConnectionEnabledSpecified = true;
                _crConnectionEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool CrConnectionEnabledSpecified { get; set; }

        private int _crConnectionTimeoutMilliseconds;

        [XmlElement(ElementName = "crConnectionTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38709")]
        [MinInclusive(1000)]
        [MaxInclusive(32000)]
        public int CrConnectionTimeoutMilliseconds
        {
            get => _crConnectionTimeoutMilliseconds;
            set
            {
                CrConnectionTimeoutMillisecondsSpecified = true;
                _crConnectionTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrConnectionTimeoutMillisecondsSpecified { get; set; }

    }
}
