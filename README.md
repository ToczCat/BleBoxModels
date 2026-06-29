# BleBoxModels

This library contains models and enums needed for API of supported types of [BleBox.eu](https://technical.blebox.eu/) devices.

## Requirements and technologies

Project is based on .NET 8 with no external dependencies.   

## Supported devices

Library supports common features for all BleBox devices. (since v.1.0.0)  

Each device has full support. Models and enums are prepared according to the latest API
specification published at [technical.blebox.eu](https://technical.blebox.eu/). The table
below lists every supported device together with the version of the API specification the
models were prepared for.

| Device | API specification |
| ------ | ----------------- |
| airSensor | 20200831 |
| buttonBox | 20200831 |
| displayBox | 20241124 |
| gateBox | 20230102 |
| multiSensor | 20230606 |
| shutterBox | 20210413 |
| smartWindowBox | 20180604 |
| switchBox | 20200831 |
| switchBoxD | 20200831 |
| tempSensor | 20220505 |
| thermoBox | 20200229 |
| tvLiftBox | 20200518 |
| wLightBox | 20200229 |

airSensor and wLightBox are available since v1.0.0; the remaining devices were added afterwards.

## Contributing

Feel free to add features requests and report issues.