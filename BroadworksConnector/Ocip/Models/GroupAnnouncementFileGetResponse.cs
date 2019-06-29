using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAnnouncementFileGetRequest.
    /// The response contains the file size, uploaded timestamp, description and usage for
    /// an announcement file in the user announcement repository.
    /// The usage table has columns "Service Name", and "Instance Name".
    /// The Service Name values correspond to string values of the GroupService and UserService data types.
    /// With the exception of the string "Voice Portal" which is returned when the announcement is being used by Voice Portal Personalized Name.
    /// <see cref="GroupAnnouncementFileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1558""}]")]
    public class GroupAnnouncementFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1558")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private int _filesize;

        [XmlElement(ElementName = "filesize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1558")]
        public int Filesize
        {
            get => _filesize;
            set
            {
                FilesizeSpecified = true;
                _filesize = value;
            }
        }

        [XmlIgnore]
        protected bool FilesizeSpecified { get; set; }

        private string _lastUploaded;

        [XmlElement(ElementName = "lastUploaded", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1558")]
        public string LastUploaded
        {
            get => _lastUploaded;
            set
            {
                LastUploadedSpecified = true;
                _lastUploaded = value;
            }
        }

        [XmlIgnore]
        protected bool LastUploadedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1558")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable
        {
            get => _usageTable;
            set
            {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        protected bool UsageTableSpecified { get; set; }

    }
}
