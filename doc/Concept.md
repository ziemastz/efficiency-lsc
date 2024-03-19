# Concept of eLSC project

## Roadmap

-[] Find core business domain

Entities:
- Nuclide
- DecayMode
  - ElectronCapture
  - Beta
  - Alfa
  - Metastable - DelayedParticle
- ParticleEmissions <- decay spectra
  - BetaEmission
  - AlfaEmission
  - GammaXEmission
  - ConversionElectronEmission
  - AugerElectronEmission
- AtomicData
- ElectronCloud -> ElectronRearrangement process
  - Shell
  - SubShell
    - Electron
- Counter
- Vial
- Cocktail
- Efficiency

Object Value:
- AtomicNumber
- MassNumber
- HalfLife
- Unit
- Energy
- Uncertainty
- Probability
- Intensity
- ConversionCoefficient

New aproach of entities/domain of app:
- Nuklid
  - AtomicNumber
  - MassNUmber
  - Element -> name
  - Symbol - > e.g. Co-60
  - DecayData?
    - HalfLife
    - Branches
      - DecayMode(abstract class)
      - Intensive
      - Intensive
      - Intensive
      - ExcitedLevel
      - LevelHalfLife
      - DaugtherId->Nuklid(stable or not)
  - AtomicData
    - AtomicRadius
    - CosterKroningYields
    - FluorescenceYields
    - Shells->contain subshells
      - SubShell
        - AugerTransition (Vacancy(SubshellId),Occupancy,Emitting,Intensity)
        - XRayTransition (Vacancy,Occupancy, Intensity)
        - Electrons (maxElektron)
        - BindingEnergy (energy_eV)

. . . 
  
## Tech nology used
- NET8
- Visual Code
- Git, GitHub.com

## Methodology

- Clean Architecture & Code
- Domain-Driver Design **DDD**
- Test-Driver Design **TDD**
- SOLID principles

## Aim

- Lear/Practice DDD and TDD