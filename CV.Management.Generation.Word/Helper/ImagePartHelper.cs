﻿using System;
using DocumentFormat.OpenXml.Packaging;

namespace CV.Management.Generation.Word.Helpers
{
    public static class ImagePartHelper
    {                                       
        private const string ImagePart1Data = "iVBORw0KGgoAAAANSUhEUgAAADIAAAAMCAIAAACvLXk7AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTZEaa/1AAAAeElEQVRIS2OQKdlNNpIFolIQiSaOH4F0leyWKwUhCBuOgLJAQSBJwFnSxbvQuMQj8jRC1FMUWtRFg9RZkkXYnAUXGigkNWgjEc4edRYpaBClLeyhNRicBXcD1FnIQsgIIk5ThGYjBJGctuC1BDEIXqsQrwWESnYDABw4Bx8MloifAAAAAElFTkSuQmCC";

        private const string ImagePart2Data = "iVBORw0KGgoAAAANSUhEUgAAADkAAAAiCAMAAAGl0LF5AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFfUExURQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEimjjcAAAB0dFJOUwABAgMEBQYHCAkKCwwNDxASExUYGhscHyAhKSorLS4wMTIzODo8QEFCSktPUFFTVFZZWltcXmFjZGdoaW11dnt/gIGCiYqLjY6RnKCkq7S2ur2/wcXGx8jJ0NLT1dbY3N3e3+Hi5OXm6Ort7vX29/j6/P3+JJbBgQAAAAlwSFlzAAAh1QAAIdUBBJy0nQAAAhRJREFUOE/NlOtT01AQxbctFtsqpRZERUQpCj5qwfp+YQR8ouKjWKkCpeITRGX//3F370kLSdOZfnH4zSR3zzm7mZtMEhLinufpSnyGma0oyeGKvCtOIqHbnlewwjdS53+4lZd1Efu7aSuNb7v1ihy+plIqz7Tc1D7QJ2Rfnncv4dQzhEi5in5Io9KUG3L1kYTbOyQ/jpC6JcNJ+uTUOKSR/uBMn80jCIwd5quZ5mUUBAbzdnn4FQIDgcGyGypxivoyop5HpTnm+0QfI9I8y+3Ik+wiPeW20uIKAkemaE/fMZ2D65jChM9D+EoWXgsEyhBzrX/PNALlGPOk7bIJAkXC1yPFTQQKAkVCn61KQxcEioS3iOpzRDdFDcglnG+0wuTFYaLZiPAF/yQajwiX1B/9H+GA3eJuECjxd/B8/M/OOPAArmOhF36I3smXW2hqQ+1aFn1Beib2vP9t+DWD1gBHv6KhA2gNIA+LuXFDy0ur1hfGGkPY5EpZfy2X16wvjOsMYpP8u1Fdqm9b2Qa0BrDJjTsJYarO84dkHXy7OJaIxzMX3ttc50l5L+RzrvNcStaYnoxC5U9Xkz3n3jRWF8bUml7vajIvryTvPFJr1D5TrcJETeo/aP9NDv2V6MvdtFBe5yc5WY9XxeKnahVqWupdhTk8r1lH1tAaJDmxiI72fL5+EJ1hYsm+/tPFdpwdzKZjRP8Ai2J/ZDhQDFUAAAAASUVORK5CYII=";
                                              
        private const string ImagePart3Data = "/9j/4QAYRXhpZgAASUkqAAgAAAAAAAAAAAAAAP/sABFEdWNreQABAAQAAABkAAD/4QOXaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA1LjYtYzEzOCA3OS4xNTk4MjQsIDIwMTYvMDkvMTQtMDE6MDk6MDEgICAgICAgICI+IDxyZGY6UkRGIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+IDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSIiIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6Mjk5QTBCRkFFMUE0MTFFODg4QjJEOTlEN0YyNzEzOUMiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6Mjk5QTBCRjlFMUE0MTFFODg4QjJEOTlEN0YyNzEzOUMiIHhtcDpDcmVhdG9yVG9vbD0iSWxsdXN0cmF0b3IiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0idXVpZDpDQ0JENDc5QTFDNzUxMURFOEJENUM0Njk5QkYyQTcwMyIgc3RSZWY6ZG9jdW1lbnRJRD0idXVpZDpDQ0JENDc5OTFDNzUxMURFOEJENUM0Njk5QkYyQTcwMyIvPiA8ZGM6dGl0bGU+IDxyZGY6QWx0PiA8cmRmOmxpIHhtbDpsYW5nPSJ4LWRlZmF1bHQiPlByaW50PC9yZGY6bGk+IDwvcmRmOkFsdD4gPC9kYzp0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";

        //Profile picture
        //private const string ImagePart4Data = "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";

        public static void GenerateImagePart1Content(ImagePart imagePart1)
        {
            var data = GetBinaryDataStream(ImagePart1Data);
            imagePart1.FeedData(data);
            data.Close();
        }

        public static void GenerateImagePart2Content(ImagePart imagePart2)
        {
            var data = GetBinaryDataStream(ImagePart2Data);
            imagePart2.FeedData(data);
            data.Close();
        }

        public static void GenerateImagePart3Content(ImagePart imagePart3)
        {
            System.IO.Stream data = GetBinaryDataStream(ImagePart3Data);
            imagePart3.FeedData(data);
            data.Close();
        }

        public static void GenerateProfileImageContent(ImagePart imagePart4, string imageContent)
        {
            System.IO.Stream data = GetBinaryDataStream(imageContent);
            imagePart4.FeedData(data);
            data.Close();
        }

        private static System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(Convert.FromBase64String(base64String));
        }
    }
}
