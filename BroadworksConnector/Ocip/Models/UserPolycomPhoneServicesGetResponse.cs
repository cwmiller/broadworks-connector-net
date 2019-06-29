using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPolycomPhoneServicesGetRequest.
    /// <see cref="UserPolycomPhoneServicesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4f074d986b998636e2bcb0d67372b0f4:148""}]")]
    public class UserPolycomPhoneServicesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _integratePhoneDirectoryWithBroadWorks;

        [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:148")]
        public bool IntegratePhoneDirectoryWithBroadWorks
        {
            get => _integratePhoneDirectoryWithBroadWorks;
            set
            {
                IntegratePhoneDirectoryWithBroadWorksSpecified = true;
                _integratePhoneDirectoryWithBroadWorks = value;
            }
        }

        [XmlIgnore]
        protected bool IntegratePhoneDirectoryWithBroadWorksSpecified { get; set; }

        private bool _includeUserPersonalPhoneListInDirectory;

        [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:148")]
        public bool IncludeUserPersonalPhoneListInDirectory
        {
            get => _includeUserPersonalPhoneListInDirectory;
            set
            {
                IncludeUserPersonalPhoneListInDirectorySpecified = true;
                _includeUserPersonalPhoneListInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeUserPersonalPhoneListInDirectorySpecified { get; set; }

        private bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:148")]
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

        private string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:148")]
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
