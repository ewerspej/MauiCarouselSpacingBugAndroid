# MauiCarouselSpacingBugAndroid

When using a _LinearItemsLayout_ with a _CarouselView_ on Android, the `ItemsSpacing` will reduce the size of the elements in the _CarouselView_. This works correctly on iOS.

## Screenshots

iOS (correct):

<div style="display: flex;">
    <img src="https://github.com/ewerspej/MauiCarouselSpacingBugAndroid/blob/main/Screenshots/iOS.png" width="360" />
</div>

Android (incorrect):

<div style="display: flex;">
    <img src="https://github.com/ewerspej/MauiCarouselSpacingBugAndroid/blob/main/Screenshots/Android.png" width="360" />
</div>

## Code

```xml
<CarouselView
  BackgroundColor="Red"
  HeightRequest="400"
  ItemsSource="{Binding Items}"
  WidthRequest="300">
  <CarouselView.ItemsLayout>
    <LinearItemsLayout
      ItemSpacing="50"
      Orientation="Horizontal"
      SnapPointsAlignment="Center"
      SnapPointsType="MandatorySingle" />
  </CarouselView.ItemsLayout>
  <CarouselView.ItemTemplate>
    <DataTemplate x:DataType="{x:Type system:String}">
      <Grid
        Margin="0"
        Padding="0"
        BackgroundColor="Yellow">
        <Label
          FontSize="24"
          HorizontalOptions="Center"
          Text="{Binding}"
          VerticalOptions="Center" />
      </Grid>
    </DataTemplate>
  </CarouselView.ItemTemplate>
</CarouselView>
```