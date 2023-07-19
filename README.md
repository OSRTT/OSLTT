# OSLTT - Open Source Latency Test Tool 
An open source latency testing tool project - here you'll find the desktop software needed to use the tool, the firmware for the device, the circuit diagram and support. 

<a href="https://andymanic.github.io/OSRTTDocs/" target="_blank">![View the docs](view-the-docs.png)</a>
<a href="https://osrtt.com" target="_blank">![Buy a kit](buy-a-kit.png)</a>

## Get Started
- Download the most recent release from the <a href="">releases page</a>.
- Run the installer, which will install to C:\OSLTT
- Launch the software
- Allow it to install the drivers for the board
- Allow it to update the device firmware (if prompted)
- Select the test type you want to try - Monitor is the one I'd recommend trying first.
- Hit "Start Test" - if you picked monitor your screen will go black, and FPS counter on the top left should read around 1000FPS.
- Press the button on the tool to start capturing data. Let it complete then it'll close the test window.
- Take a look at the results in the results view window.
- Enjoy!

## Reporting problems
If you encounter an errant bug in the software or firmware, please do let me know. The best way to do that is here on GitHub, through the <a href="https://github.com/OSRTT/OSLTT/issues">issues tab</a>. If you don't have a GitHub account, you can also email me <a href="mailto:inbox@techteamgb.com">here</a>. Please include as much information as possible, and any screenshots relevant. 

## Feature suggestions
Much like the reporting problems section above, if you'd like to request a feature be added, please either submit <a href="https://github.com/OSRTT/OSLTT/issues">an issue</a>, or email me <a href="mailto:inbox@techteamgb.com">here</a>.

## Building from Source
- Clone the repo
- Launch the SLN in Visual Studio
- Build the solution before opening Main.cs (as SettingsPane.cs is a user control that needs to be built before displaying Main.cs)
- Copy the DirectX folder to bin/Debug
- Get a copy of the arduino CLI <a href="https://github.com/arduino/arduino-cli">here</a> and place it in a new folder called "arduinoCLI" in bin/Debug
- Run the program and enjoy!

## Contributing
### Supporting Directly
If you'd like to support the project but don't need a device, you can support by sharing the project with your favourite tech reviewers, or support directly through <a href="https://paypal.me/andymanic1?country.x=GB&locale.x=en_GB">PayPal</a>.

### Code Contribution
If you'd like to contribute some code to the project - either bug fixes or new features - please submit a pull request with as much info as possible. I'll do my best to review and merge any changes in good time. If you have any questions about my (imperfect) code, please do submit an issue and tag it as a question.
