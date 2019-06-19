using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPhoneDirectoryGetSearchedListRequest.
    /// The "My Room Room Id" and "My Room Bridge Id" are only populated for
    /// users assigned the "Collaborate-Audio" service.
    /// Contains a table with  a row for each phone number and column headings :
    /// "Name", "Number", "Extension", "Mobile", "Email Address", "Department",
    /// "Hiragana Name", "Group Id", "Yahoo Id", "User Id", "IMP Id", "First Name", "Last Name",
    /// "My Room Room Id", "My Room Bridge Id", "Service Name".
    /// The Service Name represents the localized service name for service instances. The localized values are taken from the BroadworksLabel.properties file.
    /// Service Name is currently supporting:
    /// AutoAttendant, AutoAttendantStandard, AutoAttendantVideo, CallCenter, CallCenterStandard, CallCenterPremium
    /// HuntGroup, InstantGroupCall, VoiceMessagingGroup, RoutePoint, BroadWorksAnywhere, GroupPaging, FindmeFollowme,
    /// VoiceXML, FlexibleSeatingGuest, CollaborateAudio, MeetMeConferencing.
    /// For a Regular User or a Virtual On Network Enterprise Extensions, the Service Name is empty.
    /// 
    /// The following columns are only returned in AS data mode:
    /// "My Room Room Id", "My Room Bridge Id", "Service Name"
    /// <see cref="UserPhoneDirectoryGetSearchedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3198""}]")]
    public class UserPhoneDirectoryGetSearchedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3198")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DirectoryTable
        {
            get => _directoryTable;
            set
            {
                DirectoryTableSpecified = true;
                _directoryTable = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryTableSpecified { get; set; }

    }
}
