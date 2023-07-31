==== Unity 2022.3 LTS URP custom shader example for new features

This is an example of a custom shader in URP which supports the new features added in URP 14.

The new features supported are:
1. Forward+ Renderer
2. Rendering Layers for lights and decals
3. LOD Cross Fade
4. SH Evaluation mode

Scenes
- Assets/Scenes/ForwardPlus.unity:  Scene using Forward+ Renderer.  The scene has a quad lit by 64 point lights.  The standard Forward renderer only allows up to 8.
- Assets/Scenes/RenderLayers.unity:  Scene showing rendering layers for lights and decals.  There are 2 rendering layers: RenderLayer1, RenderLayer2.  The point light and decal projector only affect RenderLayer1.
- Assets/Scenes/LODCrossFade.unity:  Scene showing LOD Cross Fade.  Moving the camera toward/away from the mesh will show blending between different LOD levels (the LOD levels are of completely different meshes to make the cross fade easier to see).

Shaders
- Assets/Shaders/Sample-Lit.shader: Example custom shader used in the sample scenes.  It is a basic lit shader which includes the following features:
--- SRP Batcher compatible
--- Forward, Forward+, and Deferred renderer support
--- Rendering Layers support
--- LOD Cross Fade support
--- SH Evaluation Mode support
--- Lightmaps
--- Rendering Debugger support