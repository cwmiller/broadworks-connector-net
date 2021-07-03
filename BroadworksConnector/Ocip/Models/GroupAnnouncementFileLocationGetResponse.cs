using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAnnouncementFileLocationGetRequest.
    /// <see cref="GroupAnnouncementFileLocationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0729212f68d12c248c92a1b3b3aa84d6:69""}]")]
    public class GroupAnnouncementFileLocationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _fileLocation;

        [XmlElement(ElementName = "fileLocation", IsNullable = false, Namespace = "")]
        [Group(@"0729212f68d12c248c92a1b3b3aa84d6:69")]
        [MinLength(1)]
        [MaxLength(256)]
        public string FileLocation
        {
            get => _fileLocation;
            set
            {
                FileLocationSpecified = true;
                _fileLocation = value;
            }
        }

        [XmlIgnore]
        protected bool FileLocationSpecified { get; set; }

    }
}
