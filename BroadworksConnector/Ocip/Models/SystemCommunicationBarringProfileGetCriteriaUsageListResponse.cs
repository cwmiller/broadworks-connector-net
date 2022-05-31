using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringProfileGetCriteriaUsageListRequest.
    /// The response contains a table of system Communication Barring Profiles that
    /// use the specific Communication Barring Criteria. The column headings
    /// are "Name" and "Description"
    /// <see cref="SystemCommunicationBarringProfileGetCriteriaUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6323""}]")]
    public class SystemCommunicationBarringProfileGetCriteriaUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6323")]
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
