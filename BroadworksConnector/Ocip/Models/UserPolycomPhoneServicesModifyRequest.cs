using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Polycom Phone Services attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4f074d986b998636e2bcb0d67372b0f4:167""}]")]
    public class UserPolycomPhoneServicesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
        public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }

        private bool _integratePhoneDirectoryWithBroadWorks;

        [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
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
        public bool IntegratePhoneDirectoryWithBroadWorksSpecified { get; set; }

        private bool _includeUserPersonalPhoneListInDirectory;

        [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
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
        public bool IncludeUserPersonalPhoneListInDirectorySpecified { get; set; }

        private bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
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
        public bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }

        private string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:167")]
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
        public bool GroupCustomContactDirectorySpecified { get; set; }

    }
}
