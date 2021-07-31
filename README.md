# ESADS
A structural analysis and design software developed based on the Ethiopian Building Code of Standards(EBCS-1995). This code is written together with my colleagues during our undergraduate study. The technique uses the spectral representation method to generate ABL-like turbulence with prescribed two-point flow statistics. The code is developed as a utility application using OpenFOAM's framework. 

Using ESADS one can anlyse and design the following reinforced concreate structures:

- Beam
- Biaxial columns 
- Foundation footings  

In this version of the code, the divergence-free condition is imposed on the generated turbulence by adding a gradient of a velocity potential, following the procedure developed by *Shirani et al.(1981)*(similar to approach used in the paper). The final velocity field is written for each time step in the corresponding case directory. Mathematical details of the implemented procedure can be found in [Melaku and Bitsuamlak(2021)](https://www.sciencedirect.com/science/article/pii/S0167610521000660). If you find this work useful in your research and use the DFSR method or parts of it in your work, please do not forget to cite the paper. 

![screenShot](files/velocityPlots.png)

### Contributors:
1. Abiy Melaku
2. Tsinuel Geleta
3. Zeineb Mehedi
