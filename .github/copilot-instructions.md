# GitHub Copilot Instructions for RimWorld DucksNoIdeologyLimits Mod

## Mod Overview and Purpose

The **DucksNoIdeologyLimits** mod for RimWorld seeks to enhance player experience by removing certain limitations imposed by the Ideology DLC. It aims to provide players with more flexibility and control over ideological components of gameplay, allowing for diverse and unrestricted playstyles.

## Key Features and Systems

- **Removal of Ideology Limits**: The mod focuses on removing arbitrary restrictions related to ideologies, enabling players to add more ideological elements than the base game permits.
- **UI Enhancements**: Streamlined user interface modifications to support enhanced ideology interaction.
- **Customization**: Provides configurable settings to tailor the mod's impact on gameplay, directly accessible via the mod menu.

## Coding Patterns and Conventions

- **Class Naming**: Classes are named following PascalCase and typically precede with `DucksNoIdeologyLimits_` to denote mod-specific functionality.
- **Method Naming**: Methods adhere to PascalCase and are descriptive of their function within the mod.
- **Access Modifiers**: Classes are appropriately encapsulated, with most gameplay logic classes being public, whereas settings and internal functionalities are marked as internal for encapsulation.
- **Static Classes**: Used for patching and utility functions to denote a lack of instance-specific state.

## XML Integration

Currently, there is no explicit XML integration mentioned, indicating all mod logic is handled via C# scripts. However, typical RimWorld mods may utilize XML for defining game components, so ensure any future XML integration follows clarity and modularity.

## Harmony Patching

- **Harmony Use**: The mod uses Harmony to patch existing RimWorld methods for overriding or extending their functionalities. This typically involves:
  - Prefix and Postfix methods to inject additional logic before or after the original method logic.
  - Transpilers if complex method replacements are necessary, although not mentioned in the current summary.

## Suggestions for Copilot

1. **Propose Descriptive Comments**: Ensure all methods and classes have informative XML comments that describe their purpose and any dependencies.
2. **Recommend Refactoring Opportunities**: If methods grow too large or multi-purpose, suggest refactoring into smaller utility methods or classes.
3. **Generate Method Stubs**: Use detected naming patterns to auto-generate methods and fill in boilerplate using names from provided instructions.
4. **Predict Test Cases**: Offer unit test cases based on existing methods to ensure expected behavior.
5. **Codify Best Practices**: Suggest improvements or corrections following C# and Harmony best practices.

This instructions file should aid in maintaining code cohesiveness, improving collaboration, and integrating automation tools effectively.
