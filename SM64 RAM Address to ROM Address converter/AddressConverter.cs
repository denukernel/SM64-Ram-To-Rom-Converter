using System;
using System.Collections.Generic;

namespace SM64_RAM_Address_to_ROM_Address_converter
{
    public static class AddressConverter
    {
        public struct MemoryRegion
        {
            public uint RamStart;
            public uint RamEnd;
            public uint RomStart;
            public string Description;
            public bool IsRamOnly; // New flag for regions that don't map to ROM

            public MemoryRegion(uint ramStart, uint ramEnd, uint romStart, string description, bool isRamOnly = false)
            {
                RamStart = ramStart;
                RamEnd = ramEnd;
                RomStart = romStart;
                Description = description;
                IsRamOnly = isRamOnly;
            }
        }

        public static Dictionary<uint, string> KnownAddresses = new Dictionary<uint, string>()
        {
            // Mario Colors (Standard US RAM -> Extended ROM Source from sm64-randomizer)
            // Base ROM: 0x823B64 (Overalls)
            { 0x8007EC58, "Mario's Overalls (Blue) [Heap] -> Extended ROM: 0x823B64" },
            { 0x8007EC88, "Mario's Hat/Shirt (Red) [Heap] -> Extended ROM: 0x823B84" }, // 0x823B64 + 0x20
            { 0x8007EC90, "Mario's Gloves [Heap] -> Extended ROM: 0x823B9C" },           // 0x823B64 + 0x38
            { 0x8007ECA0, "Mario's Shoes [Heap] -> Extended ROM: 0x823BAC" },            // 0x823B64 + 0x48
            { 0x8007ECB8, "Mario's Skin [Heap] -> Extended ROM: 0x823BC4" },             // 0x823B64 + 0x60
            { 0x8007ECD8, "Mario's Hair [Heap] -> Extended ROM: 0x823BE4" },             // 0x823B64 + 0x80
            
            // Lights (Approximate RAM)
            { 0x8007EC20, "Mario's Lights 1 [Heap] (No direct ROM source confirmed)" }, 
            { 0x8007EC38, "Mario's Lights 2 [Heap] (No direct ROM source confirmed)" }
        };

        public static List<MemoryRegion> Regions = new List<MemoryRegion>()
        {
            // Boot / Framebuffers / Heap
            new MemoryRegion(0x80000000, 0x80245FFF, 0x000000, "Boot / Code / Heap (Dynamic)", true),
            
            // Standard SM64 US mappings
            new MemoryRegion(0x80246000, 0x8033A57F, 0x001000, "Main Code / Static Data"),
            new MemoryRegion(0x80378800, 0x8038BC8F, 0x0F5580, "Engine / Global Data")
            // Add more as needed
        };

        public static bool TryConvert(uint ramAddress, out uint romAddress, out string regionDescription)
        {
            romAddress = 0;
            regionDescription = "Unknown";

            // Check standard regions
            foreach (var region in Regions)
            {
                if (ramAddress >= region.RamStart && ramAddress <= region.RamEnd)
                {
                    regionDescription = region.Description;

                    // Check for known specific addresses
                    if (KnownAddresses.ContainsKey(ramAddress))
                    {
                        regionDescription += $" - {KnownAddresses[ramAddress]}";
                    }

                    if (region.IsRamOnly)
                    {
                        romAddress = 0; // Or dummy value
                        regionDescription += " (No direct ROM mapping)";
                        return false; // Valid RAM, but no ROM address
                    }
                    else
                    {
                        uint offset = ramAddress - region.RamStart;
                        romAddress = region.RomStart + offset;
                        return true;
                    }
                }
            }

            // Simple heuristic for Expansion Pak (often mapped linearly for extended ROMs)
            // Common setup: 0x80400000 -> Start of extended area (variable)
            // But without user config, we can't be sure. 
            // We'll return false for now, or just leave it as Unknown.
            
            return false;
        }

        public static string FormatAddress(uint addr)
        {
            return $"0x{addr:X8}";
        }
    }
}
