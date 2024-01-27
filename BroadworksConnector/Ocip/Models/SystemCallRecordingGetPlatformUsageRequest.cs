using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of groups currently associated to the specified Call Recording platform.
    /// The response is either SystemCallRecordingGetPlatformUsageResponse or ErrorResponse.
    /// 
    /// Replaced by SystemCallRecordingGetPlatformUsageRequest22 in AS data mode.
    /// <see cref="SystemCallRecordingGetPlatformUsageResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingGetPlatformUsageRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9209""}]")]
    public class SystemCallRecordingGetPlatformUsageRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallRecordingGetPlatformUsageResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9209")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
