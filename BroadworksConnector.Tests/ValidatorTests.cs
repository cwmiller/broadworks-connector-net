using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BroadWorksConnector.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void TestRequirementMissing()
        {
            var request = new LoginRequest14sp4();
            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<FieldNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestRequirementMet()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = "test"
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestRequirementWithInheritedPropertyMet()
        {
            var request = new GroupUserCallForwardingSettingsGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "GRP",
                CallForwardingService = CallForwardingService.CallForwardingAlways,
                ResponsePagingControl = new ResponsePagingControl
                {
                    ResponsePageSize = 10,
                    ResponseStartIndex = 1
                },
                SortByExtension = new SortByExtension
                {
                    IsAscending = false,
                    IsCaseSensitive = false
                }
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestRequirementWithInheritedPropertyNotMet()
        {
            var request = new GroupUserCallForwardingSettingsGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "GRP",
                CallForwardingService = CallForwardingService.CallForwardingAlways,
                ResponsePagingControl = new ResponsePagingControl
                {
                    ResponsePageSize = 10,
                    ResponseStartIndex = 1
                },
                SortByExtension = new SortByExtension
                {
                    IsAscending = false
                    // Missing isCaseSensitive
                }
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<FieldNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestRequirementWithArrayNotMet()
        {
            var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
            {
                ServiceProviderId = "SID",
                GroupId = "GID"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<FieldNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestRequirementArrayEmpty()
        {
            var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
            {
                ServiceProviderId = "SID",
                GroupId = "GID",
                Code = new List<CommunicationBarringAuthorizationCodeEntry>()
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<FieldNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestRequirementWithArrayMet()
        {
            var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
            {
                ServiceProviderId = "SID",
                GroupId = "GID",
                Code = new List<CommunicationBarringAuthorizationCodeEntry>()
                {
                    new CommunicationBarringAuthorizationCodeEntry()
                    {
                        Code = "123"
                    }
                }
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestChoiceNotMet()
        {
            var request = new UserModifyRequest16Endpoint();
            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<ChoiceNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestMultipleChoiceSelections()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                UserId = "userId",
                LinePort = "linePort"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<InvalidChoiceError>(results.Errors.Single());
        }

        [Fact]
        public void TestSequenceSetInChoice()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                SvcProviderId = "svc",
                GroupId = "group"
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestMultipleChoiceWithSequence()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                GroupId = "group",
                SvcProviderId = "svc",
                ResellerId = "reseller"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<InvalidChoiceError>(results.Errors.Single());
        }

        [Fact]
        public void TestChoiceWithOptionalMembers()
        {
            var request = new UserAddRequest21()
            {
                ServiceProviderId = "SP",
                GroupId = "GR",
                UserId = "user@test.com",
                FirstName = "John",
                LastName = "Doe",
                CallingLineIdFirstName = "John",
                CallingLineIdLastName = "Doe"
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestChoiceWithUnsetArrays()
        {
            var request = new GroupCallCenterAddAgentListRequest()
            {
                ServiceUserId = "test@test.com"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<ChoiceNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestChoiceWithEmptyArrays()
        {
            var request = new GroupCallCenterAddAgentListRequest()
            {
                ServiceUserId = "test@test.com",
                AgentUserId = new List<string>() { "user@test.com" }
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestChoiceWithSetArrays()
        {
            var request = new GroupCallCenterAddAgentListRequest()
            {
                ServiceUserId = "test@test.com",
                AgentUserId = new List<string>() { "user@test.com" },
                AgentSkillList = new List<CallCenterSkillAgentList>()
                {
                    new CallCenterSkillAgentList()
                    {
                        Agent = new List<string>() { "test" },
                        SkillLevel = 1
                    }
                }
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<InvalidChoiceError>(results.Errors.Single());
        }

        [Fact]
        public void TestMultipleChoiceAndIncompleteSequence()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                SvcProviderId = "123",
                UserId = "userId"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.Equal(2, results.Errors.Count());
        }

        [Fact]
        public void TestOptionalGroup()
        {
            var request = new SystemGetRegistrationContactListRequest();
            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestIncompleteObjectInArray()
        {
            var request = new GroupAccessDeviceGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "G",
                SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                    new SearchCriteriaDeviceMACAddress()
                    {
                        Value = "000000000000",
                        Mode = SearchMode.EqualTo
                    }
                }
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<FieldNotSetError>(results.Errors.Single());
        }

        [Fact]
        public void TestCompletedObjectsInArray()
        {
            var request = new GroupAccessDeviceGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "G",
                SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "000000000000",
                            IsCaseInsensitive = false,
                            Mode = SearchMode.EqualTo
                        },
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "999999999999",
                            IsCaseInsensitive = true,
                            Mode = SearchMode.EqualTo
                        }
                    }
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestLengthFailure()
        {
            var request = new FaxMessagingMenuKeysModifyEntry()
            {
                SaveFaxMessageAndSkipToNext = "11"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<LengthError>(results.Errors.Single());
        }

        [Fact]
        public void TestMinLengthFailure()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = ""
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<MinLengthError>(results.Errors.Single());
        }

        [Fact]
        public void TestMinLengthSuccess()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = "a"
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestMaxLengthFailure()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = new String('a', 162)
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<MaxLengthError>(results.Errors.Single());
        }

        [Fact]
        public void TestMaxLengthSuccess()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = new String('a', 161)
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestPatternFailure()
        {
            var request = new FaxMessagingMenuKeysModifyEntry()
            {
                SaveFaxMessageAndSkipToNext = "a"
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<PatternError>(results.Errors.Single());
        }

        [Fact]
        public void TestPatternSuccess()
        {
            var request = new FaxMessagingMenuKeysModifyEntry()
            {
                SaveFaxMessageAndSkipToNext = "#"
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestMinInclusiveFailure()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 1
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<MinInclusiveError>(results.Errors.Single());
        }

        [Fact]
        public void TestMinInclusiveSuccess()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 3
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestMaxInclusiveFailure()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 21
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.IsType<MaxInclusiveError>(results.Errors.Single());
        }

        [Fact]
        public void TestMaxInclusiveSuccess()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 20
            };

            var results = Validator.Validate(request);

            Assert.True(results.Success);
        }

        [Fact]
        public void TestMultipleValidationFailures()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 21,
                MaxExtensionLength = 1
            };

            var results = Validator.Validate(request);

            Assert.False(results.Success);
            Assert.Equal(2, results.Errors.Count());
        }

        [Fact]
        public void TestNillablePropertyNull()
        {
            var request = new UserModifyRequest22()
            {
                UserId = "john.doe@test.com",
                PhoneNumber = null
            };
            var results = Validator.Validate(request);
            Assert.True(results.Success);
        }

        [Fact]
        public void TestNillablePropertyFilled()
        {
            var request = new UserModifyRequest22()
            {
                UserId = "john.doe@test.com",
                PhoneNumber = "15555555555"
            };
            var results = Validator.Validate(request);
            Assert.True(results.Success);
        }


    }
}
