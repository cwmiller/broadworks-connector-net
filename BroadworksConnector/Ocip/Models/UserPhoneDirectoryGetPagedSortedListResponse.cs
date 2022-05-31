using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPhoneDirectoryGetPagedSortedListRequest.
    /// Returns the number of entries that would be returned if the response
    /// Was not page size restricted.
    /// The "My Room Room Id" and "My Room Bridge Id" are only populated for
    /// users assigned the "Collaborate-Audio" service.
    /// Contains a table with a row for each user and column headings:
    /// "User Id", "CLID First Name", "CLID Last Name", "First Name",
    /// "Last Name", "Hiragana First Name", "Hiragana Last Name",
    /// "Title", "Phone Number", "Extension", "Mobile", "Pager",
    /// "Email Address", "Yahoo Id", "Department", "Group Id", "Location",
    /// "Address Line 1", "Address Line 2", "City", "State", "Zip",
    /// "Country", "IMP Id", "Location Code", "My Room Room Id",
    /// "My Room Bridge Id", "Service Name", and "Receptionist Note".
    /// The Service Name represents the localized service name for service instances.
    /// The localized values are taken from the BroadworksLabel.properties file.
    /// Service Name is currently supporting:
    /// AutoAttendant, AutoAttendantStandard, AutoAttendantVideo, CallCenter,
    /// CallCenterStandard, CallCenterPremium, HuntGroup, InstantGroupCall,
    /// VoiceMessagingGroup, RoutePoint, BroadWorksAnywhere, GroupPaging, FindmeFollowme,
    /// VoiceXML, FlexibleSeatingGuest, CollaborateAudio, MeetMeConferencing.
    /// For a Regular User or a Virtual On Network Enterprise Extensions, the
    /// Service Name is empty.
    /// The Receptionist Note column is only populated, if the user sending
    /// the request is the owner of the Receptionist Note and a Note exists.
    /// 
    /// The following columns are returned in AS data mode only:
    /// "Service Name", "Receptionist Notes"
    /// <see cref="UserPhoneDirectoryGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3180""}]")]
    public class UserPhoneDirectoryGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3180")]
        public int TotalNumberOfRows
        {
            get => _totalNumberOfRows;
            set
            {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        protected bool TotalNumberOfRowsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3180")]
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
        protected bool DirectoryTableSpecified { get; set; }

    }
}
