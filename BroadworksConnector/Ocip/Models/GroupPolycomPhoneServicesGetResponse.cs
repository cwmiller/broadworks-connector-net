using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPolycomPhoneServicesGetRequest.
    /// <see cref="GroupPolycomPhoneServicesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ff29a940e42c5c9737f7438c4e6eea9d:62""}]")]
    public class GroupPolycomPhoneServicesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _includeGroupCommonPhoneListInDirectory;

        [XmlElement(ElementName = "includeGroupCommonPhoneListInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:62")]
        public bool IncludeGroupCommonPhoneListInDirectory
        {
            get => _includeGroupCommonPhoneListInDirectory;
            set
            {
                IncludeGroupCommonPhoneListInDirectorySpecified = true;
                _includeGroupCommonPhoneListInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeGroupCommonPhoneListInDirectorySpecified { get; set; }

        protected bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:62")]
        public bool IncludeGroupCustomContactDirectoryInDirectory
        {
            get => _includeGroupCustomContactDirectoryInDirectory;
            set
            {
                IncludeGroupCustomContactDirectoryInDirectorySpecified = true;
                _includeGroupCustomContactDirectoryInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }

        protected string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:62")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupCustomContactDirectory
        {
            get => _groupCustomContactDirectory;
            set
            {
                GroupCustomContactDirectorySpecified = true;
                _groupCustomContactDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCustomContactDirectorySpecified { get; set; }

    }
}
