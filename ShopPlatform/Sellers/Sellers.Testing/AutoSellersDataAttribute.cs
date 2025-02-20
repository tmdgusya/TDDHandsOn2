﻿using AutoFixture;
using AutoFixture.Xunit2;

namespace Sellers;

public class AutoSellersDataAttribute : AutoDataAttribute
{
    public AutoSellersDataAttribute()
        : base(() => new Fixture().Customize(
            new CompositeCustomization(
                new UserCustomization(),
                new RoleCustomization(),
                new ShopCustomization(),
                new PasswordHasherCustomization(),
                new SellersDbContextCustomization(),
                new UserRepositoryCustomization(),
                new SellersServerCustomization())))
    {
    }
}
