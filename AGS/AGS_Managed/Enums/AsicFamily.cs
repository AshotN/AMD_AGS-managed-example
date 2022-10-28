namespace AGS.AGS_Managed.Enums
{
    /// The ASIC family
    public enum AsicFamily
    {
        AsicFamily_Unknown,                                         ///< Unknown architecture, potentially from another IHV. Check \ref AGSDeviceInfo::vendorId
        AsicFamily_PreGCN,                                          ///< Pre GCN architecture.
        AsicFamily_GCN1,                                            ///< AMD GCN 1 architecture: Oland, Cape Verde, Pitcairn & Tahiti.
        AsicFamily_GCN2,                                            ///< AMD GCN 2 architecture: Hawaii & Bonaire.  This also includes APUs Kaveri and Carrizo.
        AsicFamily_GCN3,                                            ///< AMD GCN 3 architecture: Tonga & Fiji.
        AsicFamily_GCN4,                                            ///< AMD GCN 4 architecture: Polaris.
        AsicFamily_Vega,                                            ///< AMD Vega architecture, including Raven Ridge (ie AMD Ryzen CPU + AMD Vega GPU).
        AsicFamily_RDNA,                                            ///< AMD RDNA architecture
        AsicFamily_RDNA2,                                           ///< AMD RDNA2 architecture

        AsicFamily_Count                                            ///< Number of enumerated ASIC families
    }
}
