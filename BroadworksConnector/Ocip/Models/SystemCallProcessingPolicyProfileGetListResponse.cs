using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCallProcessingPolicyProfileGetListRequest.
    /// The response contains a table of all Call Processing Policy Profiles
    /// in the system. The column headings are "Name" and "Description".
    /// <see cref="SystemCallProcessingPolicyProfileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:3570""}]")]
    public class SystemCallProcessingPolicyProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callProcessingPolicyProfilesTable;

        [XmlElement(ElementName = "callProcessingPolicyProfilesTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:3570")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallProcessingPolicyProfilesTable
        {
            get => _callProcessingPolicyProfilesTable;
            set
            {
                CallProcessingPolicyProfilesTableSpecified = true;
                _callProcessingPolicyProfilesTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallProcessingPolicyProfilesTableSpecified { get; set; }

    }
}
