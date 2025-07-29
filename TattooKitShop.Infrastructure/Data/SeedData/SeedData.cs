using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooKitShop.Infrastructure.Data.Models;

namespace TattooKitShop.Infrastructure.Data.SeedData
{
    internal class SeedData
    {
        public Category Ink { get; private set; }
        public Category Machines { get; private set; }
        public Category Cartridges { get; private set; }
        public Category Needles { get; private set; }
        public Category PowerSupplies { get; private set; }
        public Category TattooHygieneAndAfterCare { get; private set; }
        public Category PierciengSupplies { get; private set; }
        public Category TattooingSupplies { get; private set; }


        //Tattoo Machine & Kit Brands
        public Brand Dragonhawk { get; private set; }
        public Brand FKIrons { get; private set; }
        public Brand Cheyenne { get; private set; }
        public Brand BishopRotary { get; private set; }
        public Brand InkJecta { get; private set; }
        public Brand StigmaRotary { get; private set; }
        public Brand MastTattoo { get; private set; }
        public Brand Hawink { get; private set; }
        public Brand SolongTattoo { get; private set; }
        public Brand Rhein { get; private set; }

        //Tattoo Ink Brands
        public Brand DynamicColor { get; set; }
        public Brand EternalInk { get; private set; }
        public Brand Intenze { get; set; }
        public Brand WorldFamousInk { get; private set; }
        public Brand KuroSumi { get; private set; }
        public Brand StarbriteColors { get; private set; }
        public Brand MomsMillenniumInk { get; private set; }
        public Brand RadiantColors { get; private set; }

        // Needles & Cartridges Brands
        public Brand Kwadron { get; private set; }
        public Brand CheyenneSafetyCartridges { get; private set; }
        public Brand EZCartridge { get; private set; }
        public Brand RheinCartridges { get; private set; }
        public Brand TTech { get; private set; }

        //Machines
        public Product RotaryMachine { get; private set; }
        public Product CoilMachine { get; private set; }
        public Product WirelessMachine { get; private set; }
        public Product InkjectaMachine { get; private set; }
        public Product Equaliser { get; private set; }

        public Product EternalInkLipsticRed { get; private set; }
        public Product KillerInkCartridge { get; private set; }
        public Product KwadronNeedle { get; private set; }
        public Product CriticalPowerAdapter { get; private set; }
        public Product LatexBlackGloves { get; private set; }
        public Product SoothingGel { get; private set; }
        public Product ScissorsRounded { get; private set; }
        public Product ReelSkinSynthetic { get; private set; }




        public SeedData()
        {
            SeedCategories();
            SeedBrand();
            SeedProduct();
        }
        private void SeedCategories()
        {
            Ink = new Category()
            {
                Id = 1,
                Name = "Ink",
            };
            Machines = new Category()
            {
                Id = 2,
                Name = "Machines",
            };
            Cartridges = new Category()
            {
                Id = 3,
                Name = "Cartridges",
            };
            Needles = new Category()
            {
                Id = 4,
                Name = "Needles",
            };
            PowerSupplies = new Category()
            {
                Id = 5,
                Name = "PowerSupplies",
            };
            TattooHygieneAndAfterCare = new Category()
            {
                Id = 6,
                Name = "TattooHygieneAndAfterCare"
            };
            PierciengSupplies = new Category()
            {
                Id = 7,
                Name = "Pierciengs"
            };
            TattooingSupplies = new Category()
            {
                Id = 8,
                Name = "Accessories"
            };

        }
        private void SeedBrand()
        {
            Dragonhawk = new Brand()
            {
                Id = 1,
                Name = "Dragonhawk"
            };
            FKIrons = new Brand()
            {
                Id = 2,
                Name = "FKIrons"
            };
            Cheyenne = new Brand()
            {
                Id = 3,
                Name = "Cheyenne"
            };
            InkJecta = new Brand()
            {
                Id = 4,
                Name = "InkJecta"
            };
            StigmaRotary = new Brand()
            {
                Id = 5,
                Name = "StigmaRotary"
            };
            MastTattoo = new Brand()
            {
                Id = 6,
                Name = "MastTattoo"
            };
            Hawink = new Brand()
            {
                Id = 7,
                Name = "Hawink"
            };
            SolongTattoo = new Brand()
            {
                Id = 8,
                Name = "SolongTattoo"
            };
            Rhein = new Brand()
            {
                Id = 9,
                Name = "Rhein"
            };

            DynamicColor = new Brand()
            {
                Id = 10,
                Name = "DynamicColor"
            };
            EternalInk = new Brand()
            {
                Id = 11,
                Name = "EternalInk"
            };
            Intenze = new Brand()
            {
                Id = 12,
                Name = "Intenze"
            };
            WorldFamousInk = new Brand()
            {
                Id = 13,
                Name = "WorldFamousInk"
            };
            KuroSumi = new Brand()
            {
                Id = 14,
                Name = "KuroSumi"
            };
            StarbriteColors = new Brand()
            {
                Id = 15,
                Name = "StarbriteColors"
            };
            MomsMillenniumInk = new Brand()
            {
                Id = 16,
                Name = "MomsMillenniumInk"
            };
            RadiantColors = new Brand()
            {
                Id = 17,
                Name = "RadiantColors"
            };

            Kwadron = new Brand()
            {
                Id = 18,
                Name = "Kwadron"
            };
            EZCartridge = new Brand()
            {
                Id = 19,
                Name = "EZCartridge"
            };
            RheinCartridges = new Brand()
            {
                Id = 20,
                Name = "RheinCartridges"
            };
            TTech = new Brand()
            {
                Id = 21,
                Name = "TTech"
            };



        }
        private void SeedProduct()
        {
            RotaryMachine = new Product()
            {
                Id = 1,
                Name = "RotaryMachine",
                Description = "The RotaryMachine is a professional-grade rotary tattoo machine designed for precision, durability, and comfort. Crafted with a lightweight aluminum alloy frame, this machine provides reduced hand fatigue, making it ideal for long tattooing sessions. Its powerful yet quiet motor delivers smooth and consistent needle movement, ensuring clean lines and even shading on every pass.",
                Price = 239.99m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/cache/2c4bd45544cd1188f156b1d5eda439e2/d/r/dragonhawk-fold-pro-wireless-pen-tattoo-machine-black-multiple-stroke.jpg",
                BrandId = 5,
                CategoryId = 2
            };
            WirelessMachine = new Product()
            {
                Id= 2,
                Name = "WirelessMachine",
                Description = "The WirelessMachine is a cutting-edge wireless tattoo machine built for artists who value freedom, performance, and precision. Designed with a sleek, ergonomic body and a high-capacity rechargeable lithium battery, this machine eliminates the need for cords and external power supplies, offering complete mobility and a cleaner workstation.",
                Price = 355.49m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/cache/2c4bd45544cd1188f156b1d5eda439e2/d/r/dragonhawk-fold-pro-wireless-pen-tattoo-machine-black-multiple-stroke.jpg",
                BrandId = 4,
                CategoryId = 2

            };
            CoilMachine = new Product()
            {
                Id = 3,
                Name = "Coil Tattoo Machine",
                Description = "Traditional coil machine offering powerful performance and deep penetration for bold lines and solid shading. Built with durable steel frame and adjustable contact screw for fine tuning.",
                Price = 179.99m,
                ImageUrl = "https://tattooequipmentgallery.com/images/coil-machine.jpg",
                BrandId = 1, 
                CategoryId = 2
            };

            InkjectaMachine = new Product()
            {
                Id = 4,
                Name = "Inkjecta Flite Nano Elite",
                Description = "High-end rotary machine from InkJecta featuring adjustable give and precise motor control. Designed for artists needing versatility in both lining and shading.",
                Price = 429.99m,
                ImageUrl = "https://www.tattoosafe.org/media/image/product/14879/lg/inkjecta-flite-nano-elite-rotary-machine_1.jpg",
                BrandId = 4,
                CategoryId = 2
            };

            Equaliser = new Product()
            {
                Id = 5,
                Name = "Equaliser Proton Pen",
                Description = "Ergonomic and versatile pen-style tattoo machine ideal for all styles. Powerful motor with consistent output and low vibration for smooth work.",
                Price = 199.00m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/e/q/equaliser-proton-pen-v2-1.jpg",
                BrandId = 3, 
                CategoryId = 2
            };

            EternalInkLipsticRed = new Product()
            {
                Id = 6,
                Name = "Eternal Ink – Lipstick Red",
                Description = "Vibrant, long-lasting red ink perfect for lip tones, flowers, and bold fills. Smooth consistency and high pigment saturation.",
                Price = 19.95m,
                ImageUrl = "https://www.tattoomedicsupply.com/wp-content/uploads/2021/10/Eternal-Ink-Lipstick-Red-1oz.jpg",
                BrandId = 11, 
                CategoryId = 1
            };

            KillerInkCartridge = new Product()
            {
                Id = 7,
                Name = "Killer Ink Cartridges – Round Liner",
                Description = "Premium tattoo cartridges with membrane and surgical steel needles. Sterile, precise, and compatible with most rotary machines.",
                Price = 29.99m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/k/i/killer-ink-cartridges-round-liner-01.jpg",
                BrandId = 19, 
                CategoryId = 3
            };

            KwadronNeedle = new Product()
            {
                Id = 8,
                Name = "Kwadron Magnum Shader Needles",
                Description = "Precision-crafted magnum needles ideal for shading and color packing. Known for sharpness and quality soldering.",
                Price = 24.50m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/k/w/kwadron-needles-magnum-1.jpg",
                BrandId = 18, 
                CategoryId = 4
            };

            CriticalPowerAdapter = new Product()
            {
                Id = 9,
                Name = "Critical Atom X-R Power Supply",
                Description = "Reliable and compact tattoo power supply with digital display, voltage memory, and jump start mode. Compatible with all rotary and coil machines.",
                Price = 219.99m,
                ImageUrl = "https://www.killerinktattoo.co.uk/media/catalog/product/c/r/critical-atom-xr.jpg",
                BrandId = 2, 
                CategoryId = 5
            };

            LatexBlackGloves = new Product()
            {
                Id = 10,
                Name = "Black Nitrile Gloves – Box of 100",
                Description = "Powder-free, medical-grade nitrile gloves in black. Provides maximum hygiene and grip while tattooing or piercing.",
                Price = 14.99m,
                ImageUrl = "https://www.thetattooshop.com/images/black-nitrile-gloves.jpg",
                BrandId = 6, 
                CategoryId = 6
            };

            SoothingGel = new Product()
            {
                Id = 11,
                Name = "Tattoo Aftercare Soothing Gel",
                Description = "Hydrating and cooling gel to aid the healing process. Reduces irritation and enhances color retention after tattoo sessions.",
                Price = 9.99m,
                ImageUrl = "https://www.tattoomed.de/media/image/product/7337/lg/aftercare-gel_1.jpg",
                BrandId = 15, 
                CategoryId = 6
            };

            ScissorsRounded = new Product()
            {
                Id = 12,
                Name = "Rounded Tip Scissors – Stainless Steel",
                Description = "Stainless steel scissors with rounded tip, perfect for cutting wraps, tapes, or bandages safely during tattoo or piercing procedures.",
                Price = 6.50m,
                ImageUrl = "https://www.medicalsupplies.co.uk/user/products/large/Sterile-Operating-Scissors-Rounded.jpg",
                BrandId = 9,
                CategoryId = 8
            };

            ReelSkinSynthetic = new Product()
            {
                Id = 13,
                Name = "ReelSkin Synthetic Tattoo Practice Skin",
                Description = "High-quality synthetic skin that mimics real human texture. Great for practicing lines, shading, and color blending.",
                Price = 17.99m,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0074/2716/6264/products/ReelSkin_FakeSkin_1.jpg",
                BrandId = 7, 
                CategoryId = 8
            };


        }
    }
}
