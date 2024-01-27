using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Auto Disable Accounts system parameters.
    /// The response is either a SuccessResponse or ErrorResponse
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2593""}]")]
    public class SystemAutoDisableAccountsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _accountInactivityTimeoutDays;

        [XmlElement(ElementName = "accountInactivityTimeoutDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        [MinInclusive(30)]
        [MaxInclusive(365)]
        public int AccountInactivityTimeoutDays
        {
            get => _accountInactivityTimeoutDays;
            set
            {
                AccountInactivityTimeoutDaysSpecified = true;
                _accountInactivityTimeoutDays = value;
            }
        }

        [XmlIgnore]
        protected bool AccountInactivityTimeoutDaysSpecified { get; set; }

        protected bool _enableAutoDisableAccounts;

        [XmlElement(ElementName = "enableAutoDisableAccounts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccounts
        {
            get => _enableAutoDisableAccounts;
            set
            {
                EnableAutoDisableAccountsSpecified = true;
                _enableAutoDisableAccounts = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsSpecified { get; set; }

        protected bool _enableAutoDisableAccountsSystemAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsSystemAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsSystemAdminLevel
        {
            get => _enableAutoDisableAccountsSystemAdminLevel;
            set
            {
                EnableAutoDisableAccountsSystemAdminLevelSpecified = true;
                _enableAutoDisableAccountsSystemAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsSystemAdminLevelSpecified { get; set; }

        protected bool _enableAutoDisableAccountsProvisioningAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsProvisioningAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsProvisioningAdminLevel
        {
            get => _enableAutoDisableAccountsProvisioningAdminLevel;
            set
            {
                EnableAutoDisableAccountsProvisioningAdminLevelSpecified = true;
                _enableAutoDisableAccountsProvisioningAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsProvisioningAdminLevelSpecified { get; set; }

        protected bool _enableAutoDisableAccountsResellerAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsResellerAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsResellerAdminLevel
        {
            get => _enableAutoDisableAccountsResellerAdminLevel;
            set
            {
                EnableAutoDisableAccountsResellerAdminLevelSpecified = true;
                _enableAutoDisableAccountsResellerAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsResellerAdminLevelSpecified { get; set; }

        protected bool _enableAutoDisableAccountsSvcProviderAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsSvcProviderAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsSvcProviderAdminLevel
        {
            get => _enableAutoDisableAccountsSvcProviderAdminLevel;
            set
            {
                EnableAutoDisableAccountsSvcProviderAdminLevelSpecified = true;
                _enableAutoDisableAccountsSvcProviderAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsSvcProviderAdminLevelSpecified { get; set; }

        protected bool _enableAutoDisableAccountsGroupAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsGroupAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsGroupAdminLevel
        {
            get => _enableAutoDisableAccountsGroupAdminLevel;
            set
            {
                EnableAutoDisableAccountsGroupAdminLevelSpecified = true;
                _enableAutoDisableAccountsGroupAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsGroupAdminLevelSpecified { get; set; }

        protected bool _enableAutoDisableAccountsDepartmentAdminLevel;

        [XmlElement(ElementName = "enableAutoDisableAccountsDepartmentAdminLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2593")]
        public bool EnableAutoDisableAccountsDepartmentAdminLevel
        {
            get => _enableAutoDisableAccountsDepartmentAdminLevel;
            set
            {
                EnableAutoDisableAccountsDepartmentAdminLevelSpecified = true;
                _enableAutoDisableAccountsDepartmentAdminLevel = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoDisableAccountsDepartmentAdminLevelSpecified { get; set; }

    }
}
