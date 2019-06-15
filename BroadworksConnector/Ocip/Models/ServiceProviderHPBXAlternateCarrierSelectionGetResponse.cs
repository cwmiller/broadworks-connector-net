using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderHPBXAlternateCarrierSelectionGetRequest.
        /// <see cref="ServiceProviderHPBXAlternateCarrierSelectionGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderHPBXAlternateCarrierSelectionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _processCbcCarrierSelection;

        [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false, Namespace = "")]
        public bool ProcessCbcCarrierSelection {
            get => _processCbcCarrierSelection;
            set {
                ProcessCbcCarrierSelectionSpecified = true;
                _processCbcCarrierSelection = value;
            }
        }

        [XmlIgnore]
        public bool ProcessCbcCarrierSelectionSpecified { get; set; }
        
        private string _preselectedLocalCarrier;

        [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = false, Namespace = "")]
        public string PreselectedLocalCarrier {
            get => _preselectedLocalCarrier;
            set {
                PreselectedLocalCarrierSpecified = true;
                _preselectedLocalCarrier = value;
            }
        }

        [XmlIgnore]
        public bool PreselectedLocalCarrierSpecified { get; set; }
        
        private string _preselectedDistantCarrier;

        [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = false, Namespace = "")]
        public string PreselectedDistantCarrier {
            get => _preselectedDistantCarrier;
            set {
                PreselectedDistantCarrierSpecified = true;
                _preselectedDistantCarrier = value;
            }
        }

        [XmlIgnore]
        public bool PreselectedDistantCarrierSpecified { get; set; }
        
    }
}
