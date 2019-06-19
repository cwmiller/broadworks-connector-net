using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetAvailableAlternateRecallUserListResponse.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name".
    /// <see cref="GroupCallParkGetAvailableAlternateRecallUserListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:115""}]")]
    public class GroupCallParkGetAvailableAlternateRecallUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

        [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:115")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableHuntGroupTable
        {
            get => _availableHuntGroupTable;
            set
            {
                AvailableHuntGroupTableSpecified = true;
                _availableHuntGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool AvailableHuntGroupTableSpecified { get; set; }

    }
}
