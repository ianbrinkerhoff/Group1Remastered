#pragma checksum "C:\Users\joeys\Source\Repos\Group1Remastered\Typing-G1\Typing\Pages\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0c200c72158d58f63dfaa35d76a49c73dbd83e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Typing.Pages.Pages_Game), @"mvc.1.0.razor-page", @"/Pages/Game.cshtml")]
namespace Typing.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\joeys\Source\Repos\Group1Remastered\Typing-G1\Typing\Pages\_ViewImports.cshtml"
using Typing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0c200c72158d58f63dfaa35d76a49c73dbd83e", @"/Pages/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7daa43da0bff1bed6b16abb8bbd909d290d49708", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Game : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div id=\"gameScreen\">        \n        <div class=\"left\" id=\"p1\">\n            <h2 id=\"currentUser\">");
#nullable restore
#line 7 "C:\Users\joeys\Source\Repos\Group1Remastered\Typing-G1\Typing\Pages\Game.cshtml"
                            Write(UserStatus.currentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <div id=""start"" style=""z-index:100"">
                <button id=""startBtn"" class=""myButton"">Start</button>
            </div>
            <div class=""wordBox1 1"" style=""top:70px""><p id=""1""></p></div>
            <div class=""wordBox1 2"" style=""top:150px""><p id=""2""></p></div>
            <div class=""wordBox1 3"" style=""top:230px""><p id=""3""></p></div>
            <div class=""wordBox1 4"" style=""top:310px""><p id=""4""></p></div>
            <div class=""wordBox1 5"" style=""top:390px""><p id=""5""></p></div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0c200c72158d58f63dfaa35d76a49c73dbd83e5502", async() => {
                WriteLiteral("\n                <input type=\"text\" name=\"user1\" id=\"tb1\"");
                BeginWriteAttribute("value", " value=\"", 789, "\"", 797, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""right"" id=""p2"">
            <h2 id=""opponent""></h2>
            <div id=""wait"">
                <h3 id=""waiting"">Waiting on opponent...</h3>
            </div>
            <div class=""wordBox 1"" style=""top:70px""><p id=""6""></p></div>
            <div class=""wordBox 2"" style=""top:150px""><p id=""7""></p></div>
            <div class=""wordBox 3"" style=""top:230px""><p id=""8""></p></div>
            <div class=""wordBox 4"" style=""top:310px""><p id=""9""></p></div>
            <div class=""wordBox 5"" style=""top:390px""><p id=""10""></p></div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0c200c72158d58f63dfaa35d76a49c73dbd83e7743", async() => {
                WriteLiteral("\n                <input type=\"text\" name=\"user2\" id=\"tb2\"");
                BeginWriteAttribute("value", " value=\"", 1492, "\"", 1500, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0c200c72158d58f63dfaa35d76a49c73dbd83e9491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral(@"
<script>
    var arr = [""BASEBALL"", ""RACECAR"", ""CACTUS"", ""SAMURAI"", ""CAT"", ""WORD"", ""BUG"", ""DINOSAUR"", ""COMPUTER"", ""TYPING"",
        ""BASKETBALL"", ""MOUSE"", ""BENCH"", ""GRAPES"", ""SOCKS"", ""RIVER"", ""ZOO"", ""DRUM"", ""LIZARD"", ""BASKETBALL"",
        ""CHEESE"", ""PURSE"", ""WATER"", ""EYE"", ""COMB"", ""ROCK"", ""LEMON"", ""CAMERA"", ""JELLYFISH"", ""ORANGE"",
        ""SWING"", ""NOSE"", ""DRAGON"", ""BUTTERFLY"", ""FORK"", ""MOUTH"", ""HEAD"", ""MILK"", ""ARM"", ""PERSON"",
        ""KING"", ""GIRL"", ""WORM"", ""RABBIT"", ""BRAD"", ""PETERSON"", ""BRACELET"", ""BALLOON"", ""OWL"", ""BIRD"",
        ""FLY"", ""FALCON"", ""BLUE"", ""GRASS"", ""SNOWFLAKE"", ""JAIL"", ""MOUNTAIN"", ""TRUCK"", ""FALL"", ""HALLOWEEN"",
        ""START"", ""RACE"", ""TABLE"", ""IMAGE"", ""BREAD"", ""SLIDE"", ""BRIDGE"", ""COAT"", ""SHIRT"", ""BEAR"",
        ""ANGEL"", ""SEA"", ""CLOUD"", ""WINDOW"", ""LIPS"", ""PILLOW"", ""RAINBOW"", ""TORNADO"", ""AIRPLANE"", ""POLICE"",
        ""KEY"", ""HAMBURGER"", ""BONE"", ""MONSTER"", ""BOW"", ""ALLIGATOR"", ""EGG"", ""ANT"", ""WHALE"", ""TURTLE"",
        ""SWIM"", ""APPLE"", ""CARROT"", ""BOOK"", ""COIN"", ""CUPCAKE"", ""PENCIL"", ""BOAT"", ""FINGER");
            WriteLiteral(@""", ""DOOR""
    ];
</script>


<script>
    var numPlayers = 0;

    ""use strict"";
    var p2count = 5;
    var connection = new signalR.HubConnectionBuilder().withUrl(""/messageHub"").build();
    var msg;

    connection.on(""ReceiveMessage"", function (username, input) {
        msg = input;
        if (msg == ""ready"") {
            numPlayers++;
            $('#waiting').html('Player Ready!')
        } else {
            $('#opponent').html(username);
            var substring = msg;
            var $div = $('#gameScreen'),
                $half = $('#p2'),
                docWidth = $div.width(),
                halfW = $half.width()

            $('.wordBox').each(function () {
                var string = $(this).text();
                if (string == substring) {
                    $('#tb1').val('');
                    $(this).text(arr[p2count]);
                    p2count++;
                    $(this).stop(true).css({
                        ""position"": ""absolute"",
                        ""left"": (docWi");
            WriteLiteral(@"dth - halfW) - 50 + ""px"",
                        ""text-align"": ""right""
                    });
                    if (p2count < 10) {
                        $(this).animate({ left: (docWidth - 100) + 'px' }, 20000);
                    } else if (p2count < 20) {
                        $(this).animate({ left: (docWidth - 100) + 'px' }, 17000);
                    } else if (p2count < 30) {
                        $(this).animate({ left: (docWidth - 100) + 'px' }, 15000);
                    } else {
                        $(this).animate({ left: (docWidth - 100) + 'px' }, 13000);
                    }
                }
                else if (string.startsWith(substring)) {
                    $(this).html(
                        '<b>' + string.substr(0, substring.length) + '</b>' + string.substr(substring.length)
                    )
                } else {
                    $(this).css({
                        ""font-weight"": ""normal"",
                        ""font-size"": ""16px""
                  ");
            WriteLiteral("  });\n                }\n            });\n        }\n    });\n\n    connection.start().then(function () {\n    }).catch(function (err) {\n        return console.error(err.string());\n    });\n\n    $(\'#tb1\').keyup(function () {\n        var username = \'");
#nullable restore
#line 117 "C:\Users\joeys\Source\Repos\Group1Remastered\Typing-G1\Typing\Pages\Game.cshtml"
                   Write(UserStatus.currentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var input = $('#tb1').val().toUpperCase();
        connection.invoke(""SendInput"", username, input).catch(function (err) {
            return console.error(err.toString());
        });
    });

    $('#start').click(function () {
        numPlayers++;
        $('#start').hide();
        var username = '");
#nullable restore
#line 127 "C:\Users\joeys\Source\Repos\Group1Remastered\Typing-G1\Typing\Pages\Game.cshtml"
                   Write(UserStatus.currentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var input = 'ready';
        connection.invoke(""SendInput"", username, input).catch(function (err) {
            return console.error(err.toString());
        });
    });
</script>

<script>

    var p1count = 5;
    

//on click populate p's with words
    $('#p1').click(function () {
        var x = 0;
        $(""p"").each(function () {
            $(this).text(arr[x]);
            x++;
            if (x >= 5) {
                x = 0;
            }
        });
    });

    //Register listener for Num Players

//PLAYER 1 SIDE USING ANIMATE
    $('#p1').click(function () {

        var $div = $('#p1'),
            docWidth = $div.width(),
            num = 0;
            

        $('#user1').css({
            'left': (docWidth / 2) - 100 + 'px',
            'visibility': 'visible'
        });

        $('#user2').css({
            'left': ((docWidth / 2) + docWidth) - 100 + 'px',
            'visibility': 'visible'
        });

        var color = setInterval(function () {
            num++;
       ");
            WriteLiteral(@"     $.each($('#p1'), function (i, left) {
                $('div', left).each(function () {
                    if (num == 1) {
                        $(this).css({
                            'color': 'orange'
                        });
                    } else if (num == 2) {
                        $(this).css({
                            'color': 'red'
                        });
                        clearInterval(color);
                    }
                });
            })
        }, 6666);


        $.each($('#p1'), function (i, left) {
            $('div', left).each(function () {
                $(this).css({
                    'position': 'absolute'
                });

                $(this).animate({ left: (docWidth - 100) + 'px' }, 20000);

            });
        })
    });


//PLAYER 2 SIDE USING ANIMATE
    $('#p1').click(function () {

        var $div = $('#gameScreen'),
            fullWidth = $div.width(),
            num = 0;

        var color = setInterval(function () {
  ");
            WriteLiteral(@"          num++;
            $.each($('#p2'), function (i, left) {
                $('div', left).each(function () {
                    if (num == 1) {
                        $(this).css({
                            'color': 'orange'
                        });
                    } else if (num == 2) {
                        $(this).css({
                            'color': 'red'
                        });
                        clearInterval(color);
                    }
                });
            }) 
        }, 6666);

       
        $.each($('#p2'), function (i, left) {
            $('div', left).each(function () {
                $(this).css({
                    'position': 'absolute'

                });

                $(this).animate({ left: (fullWidth - 100) + 'px' }, 20000);

            });
        })  
    });

//When player hits a key, it compares substring to words on players screen
    $('#tb1').keyup(function () {
        var substring = $('#tb1').val().toUpperCase();
        va");
            WriteLiteral(@"r $div = $('#p1'),
            docWidth = $div.width()
        $('.wordBox1').each(function () {
            var string = $(this).text();
            if (string == substring) {
                $('#tb1').val('');
                $(this).text(arr[p1count]);
                p1count++;
                $(this).stop(true).css({
                    ""position"": ""absolute"",
                    ""left"": ""-50px"",
                    ""text-align"": ""right""
                });
                if (p1count < 10) {
                    $(this).animate({ left: (docWidth - 100) + 'px' }, 20000);
                } else if (p1count < 20) {
                    $(this).animate({ left: (docWidth - 100) + 'px' }, 17000);
                } else if (p1count < 30) {
                    $(this).animate({ left: (docWidth - 100) + 'px' }, 15000);
                } else {
                    $(this).animate({ left: (docWidth - 100) + 'px' }, 13000);
                }
            }
            else if (string.startsWith(substring)) {
         ");
            WriteLiteral(@"       $(this).html(
                    '<b>' + string.substr(0, substring.length) + '</b>' + string.substr(substring.length)
                )
            } else {
                $(this).css({
                    ""font-weight"": ""normal"",
                    ""font-size"": ""16px""
                });
            }
        });
    });

</script>

<style>

    /* Control the left side */
    .left {
        width: 50%;
        float: left;
        background-color: whitesmoke;
        min-height: 100%;
        margin:0;
        position:absolute;
    }

    /* Control the right side */
    .right {
        width: 50%;
        float: right;
        background-color: lightgray;
        min-height: 100%;
        margin: 0;
    }

    html, body {
        height: 100%;
        margin: 0;
    }

    body {
        overflow:hidden;
        background-color: white;
        margin: 0 auto;
        position: relative;
        width: 100%;
        height: 100%;
    }

    header {
        display: block;
        width: 10");
            WriteLiteral(@"0%;
        height: 54px;
    }

    #gameScreen {
        border: 1px black solid;
        width: 100%;
        position: absolute;
        top: 54px;
        bottom: 60px;
        left: 0;
    }

    h2 {
        text-align: left;
    }

    .wordBox, .wordBox1{
        height: 50px;
        width: 100px;
        margin: 5px;
        color:green;
    }

    #finalMsg{
        visibility:collapse;
    }

    p{
        text-align:left;
        margin:auto;
    }

    #p1, #p2{
        
    }

    #user1, #user2{
        position: absolute;
        bottom:0px;
        visibility:hidden;
    }

    #start {
        position: absolute;
        left: 40%;
        top: 40%;
        text-align: center;
    }

    #wait {
        position: absolute;
        left: 65%;
        top: 40%;
        text-align: center;
    }

    .myButton {
        box-shadow: 0px 0px 0px 2px #9fb4f2;
        background-color: darkgray;
        border-radius: 10px;
        border: 1px solid #4e6096;
        display: inline-block;
      ");
            WriteLiteral(@"  cursor: pointer;
        color: #ffffff;
        font-family: Trebuchet MS;
        font-size: 21px;
        font-weight: bold;
        padding: 15px 40px;
        text-decoration: none;
        text-shadow: 0px 1px 0px #283966;
    }

        .myButton:hover {
            background-color: #476e9e;
        }

        .myButton:active {
            position: relative;
            top: 1px;
        }

</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Typing.Pages.GameModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Typing.Pages.GameModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Typing.Pages.GameModel>)PageContext?.ViewData;
        public Typing.Pages.GameModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
