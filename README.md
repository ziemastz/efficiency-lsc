# Efficiency Liquid Scintillator Counter (eLSC)

> _The Calibration of Radioactive Solutions begins with the collection of the most accurate nuclear and atomic data of the standardized radionuclide._

The **eLSC project** is designed to monitor and fetch up-to-date radionuclide data and also calculate efficiency of liquid scintillator counter (eLSC). This data is necessary to good standardized of radioactivity. The most popular technique for determining activity is the liquid scintillator technique. The construction of the measuring counter using this technique is usually built with 2 or 3 photomultiplier tubs (PMT) arranged around a measuring vial containing a liquid scintillator and a radioactive solution.
The theoretical model that calculates the efficiency of the counter consists of many elements and various assumptions. Changing the input parameters in the model makes it possible to verify it with experimental measurements.

## Features

- The radionuclide database with automatic fetching of up-to-date data from various websites.
- Combining in one place multiple codes that calculate the physics of radionuclide decay (All-In-One):
  - Spectrum of beta decay
  - Electron captures probabilities
  - Conversion electron probabilities
  - Simulation deposited energy in LSC (e.g. MICELLE2, Geant4)
- User-friendly interface, instead of the commonly used CLI.
- Tests and partial data enabling verification of the theoretical model and analysis of the calculation process.
- Keeping your own calculations in history
- Graphical visualization of calculations

## Concept

A roadmap of the project is found in the [Concept](doc/Concept.md).

### Motivation

The project was created as part of the [100COMMITOW](https://100commitow.pl) contest. The goal is to expand programming skills.
During the project, I'll improve skills in clear architecture and TDD.
Thanks the [DevMentors](https://github.com/devmentors) team for motivating me.

## License

[MIT license](https://github.com/ziemastz/efficiency-lsc/blob/main/LICENSE)