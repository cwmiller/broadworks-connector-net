using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// “Phone Number”, “Extension”, “Department”, “Email Address”. The Email Address will never be populated, since Hunt Groups don't
    /// have Email Addresses.
    /// <see cref="GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b6fd73d148b9b309dce1d2f04516ddfa:169""}]")]
    public class GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

        [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:169")]
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
