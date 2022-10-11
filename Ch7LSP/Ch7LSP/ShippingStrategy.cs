using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ch7LSP
{
    //public interface IShippingStrategy
    //{
    //    decimal flatRate { get;}
    //    decimal CalculateShippingCost(float weight, float dimention, RegionInfo region);
    //}

    internal class ShippingStrategy
    {
        public decimal flatRate { get; }

        public ShippingStrategy(decimal flatRate)
        {
            // データ不変条件
            if (flatRate <= decimal.Zero)
            {
                throw new ArgumentOutOfRangeException(
                    "flatRate",
                    "Flat Rate must be positive and non-zero");
            }
            this.flatRate = flatRate;
        }

        protected virtual decimal CalculateShippingCost(
            float packageWeightInKilograms,
            float packageDimensionsInInches,
            RegionInfo desitination)
        {
            // 事前条件
            if (packageWeightInKilograms <= 0f)
            {
                throw new ArgumentOutOfRangeException(
                    "packageWeightInKilograms",
                    "Package weight must be positive and non-zero");
            }

            var shippingCost = decimal.One;

            // 事後条件
            if (shippingCost <= decimal.Zero)
            {
                throw new ArgumentOutOfRangeException(
                    "return",
                    "The return value is out of range");
            }

            return shippingCost;
        }
    }

    internal sealed class WorldWideShippingStrategy : ShippingStrategy
    {
        public WorldWideShippingStrategy(decimal flatRate)
            : base(flatRate)
        {
        }

        protected override decimal CalculateShippingCost(
            float packageWeightInKilograms,
            float packageDimensionsInInches,
            RegionInfo desitination)
        {
            base.CalculateShippingCost(packageWeightInKilograms, packageDimensionsInInches, desitination);

            // クライアントはサブクラスを意識しない
            // サブクラスで事前条件を緩和／事後条件を厳格化してはいけない
            if (desitination == null)
            {
                throw new ArgumentNullException("dimention",
                    "Dimention should be valid value");
            }
            return decimal.MinusOne;
        }
    }
}
