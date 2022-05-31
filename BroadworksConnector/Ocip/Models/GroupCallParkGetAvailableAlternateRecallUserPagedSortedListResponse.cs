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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:169""}]")]
    public class GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

        [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:169")]
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
