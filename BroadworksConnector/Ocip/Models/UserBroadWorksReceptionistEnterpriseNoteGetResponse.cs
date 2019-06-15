using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistEnterpriseNoteGetRequest.
        /// <see cref="UserBroadWorksReceptionistEnterpriseNoteGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksReceptionistEnterpriseNoteGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _receptionistNote;

        [XmlElement(ElementName = "receptionistNote", IsNullable = false, Namespace = "")]
        public string ReceptionistNote {
            get => _receptionistNote;
            set {
                ReceptionistNoteSpecified = true;
                _receptionistNote = value;
            }
        }

        [XmlIgnore]
        public bool ReceptionistNoteSpecified { get; set; }
        
    }
}
