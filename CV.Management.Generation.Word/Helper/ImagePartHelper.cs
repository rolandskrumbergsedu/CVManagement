﻿using System;
using DocumentFormat.OpenXml.Packaging;

namespace CV.Management.Generation.Word.Helpers
{
    public static class ImagePartHelper
    {
        private const string ImagePart1Data = "iVBORw0KGgoAAAANSUhEUgAAADIAAAAMCAIAAACvLXk7AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTZEaa/1AAAAeElEQVRIS2OQKdlNNpIFolIQiSaOH4F0leyWKwUhCBuOgLJAQSBJwFnSxbvQuMQj8jRC1FMUWtRFg9RZkkXYnAUXGigkNWgjEc4edRYpaBClLeyhNRicBXcD1FnIQsgIIk5ThGYjBJGctuC1BDEIXqsQrwWESnYDABw4Bx8MloifAAAAAElFTkSuQmCC";

        private const string ImagePart2Data = "iVBORw0KGgoAAAANSUhEUgAAADkAAAAiCAMAAAGl0LF5AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFfUExURQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEimjjcAAAB0dFJOUwABAgMEBQYHCAkKCwwNDxASExUYGhscHyAhKSorLS4wMTIzODo8QEFCSktPUFFTVFZZWltcXmFjZGdoaW11dnt/gIGCiYqLjY6RnKCkq7S2ur2/wcXGx8jJ0NLT1dbY3N3e3+Hi5OXm6Ort7vX29/j6/P3+JJbBgQAAAAlwSFlzAAAh1QAAIdUBBJy0nQAAAhRJREFUOE/NlOtT01AQxbctFtsqpRZERUQpCj5qwfp+YQR8ouKjWKkCpeITRGX//3F370kLSdOZfnH4zSR3zzm7mZtMEhLinufpSnyGma0oyeGKvCtOIqHbnlewwjdS53+4lZd1Efu7aSuNb7v1ihy+plIqz7Tc1D7QJ2Rfnncv4dQzhEi5in5Io9KUG3L1kYTbOyQ/jpC6JcNJ+uTUOKSR/uBMn80jCIwd5quZ5mUUBAbzdnn4FQIDgcGyGypxivoyop5HpTnm+0QfI9I8y+3Ik+wiPeW20uIKAkemaE/fMZ2D65jChM9D+EoWXgsEyhBzrX/PNALlGPOk7bIJAkXC1yPFTQQKAkVCn61KQxcEioS3iOpzRDdFDcglnG+0wuTFYaLZiPAF/yQajwiX1B/9H+GA3eJuECjxd/B8/M/OOPAArmOhF36I3smXW2hqQ+1aFn1Beib2vP9t+DWD1gBHv6KhA2gNIA+LuXFDy0ur1hfGGkPY5EpZfy2X16wvjOsMYpP8u1Fdqm9b2Qa0BrDJjTsJYarO84dkHXy7OJaIxzMX3ttc50l5L+RzrvNcStaYnoxC5U9Xkz3n3jRWF8bUml7vajIvryTvPFJr1D5TrcJETeo/aP9NDv2V6MvdtFBe5yc5WY9XxeKnahVqWupdhTk8r1lH1tAaJDmxiI72fL5+EJ1hYsm+/tPFdpwdzKZjRP8Ai2J/ZDhQDFUAAAAASUVORK5CYII=";

        private const string ImagePart3Data = "/9j/4QAYRXhpZgAASUkqAAgAAAAAAAAAAAAAAP/sABFEdWNreQABAAQAAABkAAD/4QOXaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA1LjYtYzEzOCA3OS4xNTk4MjQsIDIwMTYvMDkvMTQtMDE6MDk6MDEgICAgICAgICI+IDxyZGY6UkRGIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+IDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSIiIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6Mjk5QTBCRkFFMUE0MTFFODg4QjJEOTlEN0YyNzEzOUMiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6Mjk5QTBCRjlFMUE0MTFFODg4QjJEOTlEN0YyNzEzOUMiIHhtcDpDcmVhdG9yVG9vbD0iSWxsdXN0cmF0b3IiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0idXVpZDpDQ0JENDc5QTFDNzUxMURFOEJENUM0Njk5QkYyQTcwMyIgc3RSZWY6ZG9jdW1lbnRJRD0idXVpZDpDQ0JENDc5OTFDNzUxMURFOEJENUM0Njk5QkYyQTcwMyIvPiA8ZGM6dGl0bGU+IDxyZGY6QWx0PiA8cmRmOmxpIHhtbDpsYW5nPSJ4LWRlZmF1bHQiPlByaW50PC9yZGY6bGk+IDwvcmRmOkFsdD4gPC9kYzp0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";


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

        private static System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(Convert.FromBase64String(base64String));
        }
    }
}
