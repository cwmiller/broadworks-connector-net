using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupIMRNGetListRequest.
        /// <see cref="GroupIMRNGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupIMRNGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _imrn;

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        public List<string> Imrn {
            get => _imrn;
            set {
                ImrnSpecified = true;
                _imrn = value;
            }
        }

        [XmlIgnore]
        public bool ImrnSpecified { get; set; }
        
    }
}
