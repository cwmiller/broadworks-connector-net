using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringProfileGetListRequest.
    /// The response contains a table of all Communication Barring Profiles
    /// in the system. The column headings are "Name" and "Description"
    /// <see cref="SystemCommunicationBarringProfileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6421""}]")]
    public class SystemCommunicationBarringProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6421")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable
        {
            get => _profileTable;
            set
            {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileTableSpecified { get; set; }

    }
}
