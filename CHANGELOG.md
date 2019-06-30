# Changelog

## [0.4.1-alpha] - 2019-06-30
### Fixed
- Fixed issue with all calls failing due to calling `Validator.Validate` on an list.
- Fixed issue with deserializing child object types.

## [0.4.0-alpha] - 2019-06-30
### Changed
- Serialization is now handled by a custom `Serializer` class instead of relying on `System.Xml.Serialization.XmlSerializer`. This has several benefits including much greater performance.
- The *PropertyName*Specified properties which are used to instruct the serializer if a property has been set and thus should be included in the output XML have been made `protected` instead of `public`.
- Extension methods for `OcipClient` have been moved to the `BroadWorksConnector` namespace so they're in the same namespace as `OcipClient`.

### Fixed
- `OcipClient` now properly calls `Validator` on execution.

[0.4.1-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.4.0-alpha...0.4.1-alpha
[0.4.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.3.0-alpha...0.4.0-alpha