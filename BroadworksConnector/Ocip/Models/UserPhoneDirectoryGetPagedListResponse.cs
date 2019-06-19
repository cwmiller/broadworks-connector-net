using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPhoneDirectoryGetPagedListRequest.
    /// Returns the number of entries that would be returned if the response
    /// Was not page size restricted.
    /// The "My Room Room Id" and "My Room Bridge Id" are only populated for
    /// users assigned the "Collaborate-Audio" service.
    /// Contains a table with a row for each user and column headings:
    /// "User Id", "First Name", "Last Name", "First Name Unicode",
    /// "Last Name Unicode", "Hiragana First Name", "Hiragana Last Name",
    /// "Title", "Phone Number", "Extension", "Mobile", "Pager",
    /// "Email Address", "Yahoo Id", "Department", "Group Id", "Location",
    /// "Address Line 1", "Address Line 2", "City", "State", "Zip", "Country",
    /// "IMP Id", "Location Code", "My Room Room Id", "My Room Bridge Id", "Service Name",
    /// and "Receptionist Note".
    /// The Service Name represents the localized service name for service instances. The localized values are taken from the BroadworksLabel.properties file.
    /// Service Name is currently supporting:
    /// AutoAttendant, AutoAttendantStandard, AutoAttendantVideo, CallCenter, CallCenterStandard, CallCenterPremium
    /// HuntGroup, InstantGroupCall, VoiceMessagingGroup, RoutePoint, BroadWorksAnywhere, GroupPaging, FindmeFollowme,
    /// VoiceXML, FlexibleSeatingGuest, CollaborateAudio, MeetMeConferencing.
    /// For a Regular User or a Virtual On Network Enterprise Extensions, the Service Name is empty.
    /// The response entries are sorted by "Last Name Unicode" first and
    /// "First Name unicode" secondarily.
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Location Code", "My Room Room Id", "My Room Bridge Id", "Service Name", "Receptionist Note"
    /// The Receptionist Note column is only populated, if the user sending
    /// the request is the owner of the Receptionist Note and a Note exists.
    /// <see cref="UserPhoneDirectoryGetPagedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3046""}]")]
    public class UserPhoneDirectoryGetPagedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3046")]
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
        public bool TotalNumberOfRowsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3046")]
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
