using System.Collections.Generic;

namespace SimpleMindmapForm.Controllers
{
    /// <summary>
    /// ツリー構造のインターフェース
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITreeNode<T>
    {
        T Parent { get; set; }
        IList<T> Children { get; set; }

        T AddChild(T child);
        T RemoveChild(T child);
        bool TryRemoveChild(T child);
        T ClearChildren();
        bool TryRemoveOwn();
        T RemoveOwn();
    }
}
