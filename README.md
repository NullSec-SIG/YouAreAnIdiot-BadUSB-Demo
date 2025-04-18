# YouAreAnIdiot BadUSB Demo
Custom remix of YouAreAnIdiot-UnFlash by @orangegrouptech for NullSec SIG's booth at SIG Fiesta 2025.

## Contents
Included are the files we used to deliver the payload via our Raspberry Pi Pico 2s, including the DuckyScript used to run the payload as well as the source code of the customised version of YouAreAnIdiot-UnFlash itself.

In our version of YouAreAnIdiot-UnFlash, we added a mini-game that involved players closing as many flying YouAreAnIdiot windows as possible within 30 seconds. Each window closed successfully would add 1 to their score. The top 3 highest scores would win an exclusive NullSec keychain, given out during the Welcome Party.

## Usage
1. Obtain a Raspberry Pi Pico, Pico W, Pico 2 or Pico 2W.
2. Use [this](https://github.com/dbisu/pico-ducky) project in order to convert the Pico into a keyboard emulator the moment it is plugged in. Obtain the CIRCUITPY `.uf2` file and follow the instructions to install just that.
3. After installing from the `.uf2`, all the files that are needed from then on for the Pico Ducky to work is here, simply download and copy + paste everything.

## YouAreAnIdiot Binaries
We are not going to provide compiled versions of the binary, but you can compile your own using the source code provided, as well as the use of Visual Studio.

## Contributors
Special thanks to all those who were involved in the conceivement of this idea:
- Orange Group Tech (@orangegrouptech) for helping us rewrite the original YouAreAnIdiot.exe to work without Adobe Flash Player
### NullSec Tech Team
- Daksh (@DakshRocks21) for coming up with the idea to use a BadUSB for the demo, as well as helping with initial research
- Chin Ray (@ChinRayTan) for the main development work on the customised version of YouAreAnIdiot-UnFlash
- Damian (@10dndnskxkd) for coming up with the gamification idea for those visiting the booth at SIG Fiesta
