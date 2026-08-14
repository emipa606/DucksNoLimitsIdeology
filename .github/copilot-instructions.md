# GitHub Copilot Instructions for Ducks' No Limits - Ideology (Continued)

## Mod Overview and Purpose
Ducks' No Limits - Ideology (Continued) is an extension of the original mod by iwishforducks which aims to liberate the players from the constraints imposed by the vanilla game regarding ideologies. This mod allows players to design their ideologies without worrying about the usual restrictions, enabling more diverse and nuanced gameplay experiences.

**Important Note:** This mod can conflict with the Vanilla Ideology Expanded. If utilizing both mods, you must use the expanded mod's settings to adjust limits.

## Key Features and Systems
- **Unlimited Memes:** Removes the restriction on the number of memes you can add to your ideology, though conflicting memes cannot be used together due to core game limitations.
- **Flexible Precepts:** Players can choose any precept irrespective of their meme selections.
- **Increased Relics:** Expands the relic cap, allowing more than the default three.
- **Expanded Rituals:** Eliminates the restriction on rituals, permitting more than six.
- **Specialist Flexibility:** Cap-disabled for specialists allowing multiple instances (except functional limitations on Leader roles).

## Coding Patterns and Conventions
- **C# File Structure:** The mod comprises multiple C# files, each targeting a specific aspect of the Ideology system.
    - `IdeoFoundation_InitPrecepts.cs`: Handles initial precept settings.
    - `IdeoUIUtility_DoPreceptsInt.cs`: Manages the precept user interface.
    - Other files follow similar functional separations.
- **Naming Conventions:** CamelCase is used for type and method names, following .NET standards.
- **Comments and Documentation:** Each file should have a clear documentation header explaining its purpose and major functions.

## XML Integration
- **About.xml:** This file is critical for specifying mod dependencies, such as `brrainz.harmony`. Ensure this file is up-to-date with any changes in dependencies or mod information.

## Harmony Patching
- **Using Harmony:**
  - All major patches utilize the Harmony library for altering existing game behavior without directly modifying the game's source code.
  - Common patching methods like `Prefix`, `Transpiler`, and `Postfix` are utilized across files, ensuring non-invasive integration.

## Suggestions for Copilot
When using GitHub Copilot with this project, consider the following:
1. **Refactor Repeated Code:** Identify repetitive patterns through Copilot suggestions and refactor these using helper methods.
2. **Generate XML Doc Comments:** Leverage Copilot to create meaningful XML documentation for classes and methods automatically.
3. **Testing and Debugging:** Suggest techniques for debugging Harmony patches and using RimWorld's logging effectively.
4. **Optimize Imports:** Ensure all necessary Harmony annotations and using directives are automatically generated where required.
5. **Enhanced Compatibility:** Recommend code patterns that improve compatibility, especially when used alongside other RimWorld mods.

By following these instructions and making strategic use of GitHub Copilot, development efficiency can be improved while maintaining a high standard of code quality. Enjoy expanding the realms of RimWorld's ideology system!

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

