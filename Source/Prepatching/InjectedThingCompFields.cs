using PurePatcher.Annotations;

namespace Kingfisher.Prepatching;

public static class InjectedThingCompFields {
    [PurePatcherField]
    [InjectComponent]
    public static extern CompExplosive? ExplosiveComp(this ThingWithComps target);

    [PurePatcherField]
    [InjectComponent]
    public static extern CompPowerTrader? PowerTraderComp(this ThingWithComps target);

    [PurePatcherField]
    [InjectComponent]
    public static extern CompUniqueWeapon? UniqueWeaponComp(this ThingWithComps target);
}