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
     
    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2bd2e9c0ba9fd02c495cbd673527444f:69""}]")]
    public class GroupAnnouncementFileLocationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {
        
        protected string _fileLocation;

        [XmlElement(ElementName = "fileLocation", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:69")]
[MinLength(1)]
[MaxLength(256)]
        public string FileLocation {
            get => _fileLocation;
            set {
                FileLocationSpecified = true;
                _fileLocation = value;
            }
        }

        [XmlIgnore]
        protected bool FileLocationSpecified { get; set; }
        
    }
}
