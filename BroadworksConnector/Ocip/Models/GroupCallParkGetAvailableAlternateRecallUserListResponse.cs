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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b6fd73d148b9b309dce1d2f04516ddfa:115""}]")]
    public class GroupCallParkGetAvailableAlternateRecallUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

        [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:115")]
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
        protected bool AvailableHuntGroupTableSpecified { get; set; }

    }
}
