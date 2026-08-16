# Decorator Pattern（裝飾者模式）

Decorator 是一種結構型設計模式。它將物件放進具有相同抽象型別的包裝物件中，在不修改原始類別的前提下，於執行階段動態加入職責。它是「組合優於繼承」的典型應用。

## 模式角色

- **Component**：定義核心物件與裝飾者共同的介面。本例為 `Beverage`。
- **Concrete Component**：可被裝飾的原始物件。本例為 `Espresso` 和 `HouseBlend`。
- **Decorator**：持有一個 `Component`，並同樣繼承 `Component`，讓裝飾後的物件可繼續被包裝。本例為 `CondimentDecorator`。
- **Concrete Decorator**：在呼叫被包裝物件前後加入行為。本例為 `Mocha`、`Soy` 和 `Whip`。
- **Client**：建立核心物件並依需求組合裝飾者。本例為 `Program.cs`。

## 運作方式

下列程式會由內而外形成包裝鏈：

```csharp
Beverage coffee = new HouseBlend();
coffee = new Mocha(coffee);
coffee = new Soy(coffee);
coffee = new Whip(coffee);
```

呼叫最外層的 `Description` 或 `Cost()` 時，每個裝飾者先委派給內層物件，再附加自己的描述或價格。因此最後得到 `House Blend Coffee, Mocha, Soy, Whip`，價格則是 `50 + 15 + 10 + 8 = 83`。

裝飾者與被裝飾物件都屬於 `Beverage`，所以 Client 不需要知道目前拿到的是原始咖啡還是經過多層包裝的咖啡。同一種裝飾者也能重複套用，例如雙份 Mocha。

## 優點

- 不修改既有類別即可增加功能，符合開放封閉原則。
- 可在執行階段自由組合、移除或調整功能順序。
- 避免為每一種功能組合建立大量子類別。
- 每個裝飾者只負責一項能力，職責較集中。

## 缺點

- 多層包裝會產生許多小物件，除錯時需要追蹤整條委派鏈。
- 裝飾順序可能影響結果，Client 必須理解組合規則。
- 若程式依賴具體類別而非共同抽象，套用裝飾者後可能不易使用。

## 適用時機

- 需要在執行階段為個別物件增加功能。
- 功能有許多可自由排列的組合，使用繼承會造成類別爆炸。
- 無法或不適合直接修改原始類別。

.NET 中的 Stream 類別是常見例子：不同 Stream 可逐層包裝，以加入緩衝、壓縮或加密等能力。

## 執行範例

```bash
dotnet run --project src/Structural/DecoratorPattern/DecoratorPattern.csproj
```
