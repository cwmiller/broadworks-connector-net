using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Service Provider Session Admission Control White List information.
    /// The number of digit pattern entries is limited to 100.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6728""}]")]
    public class ServiceProviderSessionAdmissionControlWhiteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6728")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private List<string> _addMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6728")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> AddMatchDigitPattern
        {
            get => _addMatchDigitPattern;
            set
            {
                AddMatchDigitPatternSpecified = true;
                _addMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool AddMatchDigitPatternSpecified { get; set; }

        private List<string> _deleteMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6728")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DeleteMatchDigitPattern
        {
            get => _deleteMatchDigitPattern;
            set
            {
                DeleteMatchDigitPatternSpecified = true;
                _deleteMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteMatchDigitPatternSpecified { get; set; }

        private bool _enableWhiteList;

        [XmlElement(ElementName = "enableWhiteList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6728")]
        public bool EnableWhiteList
        {
            get => _enableWhiteList;
            set
            {
                EnableWhiteListSpecified = true;
                _enableWhiteList = value;
            }
        }

        [XmlIgnore]
        protected bool EnableWhiteListSpecified { get; set; }

    }
}
