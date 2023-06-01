using System.Collections.Generic;

namespace Docfx.ResultSnippets;

/// <summary>
/// Model transformer
/// </summary>
/// <param name="models">models to transform</param>
/// <typeparam name="T">some model</typeparam>
public delegate IEnumerable<T> ModelTransformer<T>(IEnumerable<T> models);
