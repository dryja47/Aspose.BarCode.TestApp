# Aspose.BarCode Test Web Application

This single page application uses Aspose.BarCode package to recognize bar codes from user image.
User uploads an image via form input. When the "go" button is pressed, the image is shown on the page.
Ajax request with the image is sent to backend asynchronously. While the request is being processed, progress bar is shown. The picture is transferred to the BarCodeReader using a memory stream in the backend.
After the codes are recognized on the frontend, the text values of the codes are displayed, and the codes themselves are highlighted with rectangles over the picture (by creating new divs).

## Ideas for future improvements

Using canvas instead of substituting the image blob into the src attribute of the img tag. So the image and rectangle highlighting will draw directly on canvas.
