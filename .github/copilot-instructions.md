# Copilot Instructions: Ducks' No Limits - Ideology (Continued)

## Mod Overview and Purpose

**Mod Name:** Ducks' No Limits - Ideology (Continued)

Ducks' No Limits - Ideology is a mod for RimWorld that removes nearly all limitations when creating your ideology within the game. It allows players to add any precept, as many memes as possible (with some exceptions), and more than the standard number of relics and rituals. This mod offers greater freedom in how players can shape their colony's ideologies, but be aware that it is highly experimental and may lead to unexpected behavior in the game. Backup your save games before using this mod.

**Important Note:** If you use Vanilla Ideology Expanded, this mod will not override the limitations set by it; instead, use the settings provided by Vanilla Ideology Expanded.

## Key Features and Systems

- **Unlimited Memes:** Add unlimited memes to your ideology, with the exception of conflicting memes due to their inherent programming.
  
- **Precept Customization:** Modify your precepts freely. For instance, you can have the Transhumanist meme while rejecting body modification.

- **Increased Relic Capacity:** Possess more than the typical three relics.

- **Ritual Expansion:** Conduct more than the standard limit of six rituals.

- **Specialist Expansion:** Assign more specialists than normally allowed.
  - You can have multiple pawns in some roles except Leader, where only one is active at a time, and Moral Guides, where multiple active roles can coexist for different pawns.

## Coding Patterns and Conventions

- **C# Best Practices:** 
  - Use descriptive method and variable names for clarity.
  - Comment sections of code that handle significant changes, especially around modded behavior.
  - Implement proper error handling where applicable to avoid crashes.

- **File Organization:** 
  - C# files containing major changes or patches are found in specific files like `IdeoUIUtility_AddPrecept.cs`, `IdeoFoundation_CanAddForFaction.cs`, and `DucksNoIdeologyLimitsMod.cs`.

- **XML Structure:** 
  - XML files contain patch definitions, e.g., `AllowRemove.xml`, utilizing proper tags and nodes.

## XML Integration

The mod uses XML files to manage definitions and patches. Key XML components include:

- **Patching Mechanics:** Located in `AllowRemove.xml`, where predefined elements can be altered or added.
- **XML Hierarchy:** Ensure XML files are aligned with RimWorld's data structure and reflect correct tagging, such as `Defs` and `Patch` nodes.

## Harmony Patching

This mod employs Harmony to patch RimWorld's functions:

- **Harmony Instances:** Initiated in `DucksNoIdeologyLimits.cs`, setting up patches for key functionality.
- **Specific Patches:** Examples include `Transpiler` in `IdeoUIUtility_AddPrecept.cs` to modify how precepts are added.
- **Prefix and Postfix Methods:** Used in `IdeoFoundation_CanAddForFaction.cs` to extend or adjust existing game mechanics.

## Suggestions for Copilot

To effectively leverage GitHub Copilot within this project:

- **Completion Suggestions:** Use Copilot to autocomplete frequent repetitive code patterns, especially when drafting multiple patches.
- **Error Detection:** Leverage Copilot's suggestions for potential bug fixes and optimizations in C# code.
- **Integration Paths:** Utilize Copilot for XML file management by suggesting template structures for new patch definitions.
- **Harmony Guidance:** Allow Copilot to assist in the creation of Harmony prefixes, postfixes, and transpilers by proposing patterns based on similar structures in the project.

By following these guidelines, you can maintain a high-quality and robust mod development experience with Ducks' No Limits - Ideology.

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
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

