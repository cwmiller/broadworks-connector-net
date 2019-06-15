using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBusyLampFieldGetRequest18.
    /// 
    /// The following elements are only used in AS data mode:
    /// forceUseOfTCP
        /// <see cref="SystemBusyLampFieldGetRequest18"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBusyLampFieldGetResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        public bool DisplayLocalUserIdentityLastNameFirst {
            get => _displayLocalUserIdentityLastNameFirst;
            set {
                DisplayLocalUserIdentityLastNameFirstSpecified = true;
                _displayLocalUserIdentityLastNameFirst = value;
            }
        }

        [XmlIgnore]
        public bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }
        
        private bool _forceUseOfTCP;

        [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false, Namespace = "")]
        public bool ForceUseOfTCP {
            get => _forceUseOfTCP;
            set {
                ForceUseOfTCPSpecified = true;
                _forceUseOfTCP = value;
            }
        }

        [XmlIgnore]
        public bool ForceUseOfTCPSpecified { get; set; }
        
    }
}
