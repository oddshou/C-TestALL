using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = new UploadPic(146676).upload4path("E:\\map_compress\\146676");


            //Test1();

            //var code = string.Join("", "72:29:A3:84:0F:F1:58:0E:B8:1C:B6:F5:B5:F2:B8:0C".Split(':')).ToLower();


            Console.WriteLine(Dimensions.Hello);
            Console.ReadLine();
        }

        struct Dimensions
        {
            public double Length;
            //public double Width = 2;    //error
            public static double Hello = 1;
        }
 

        private static void Test1()
        {
            string region = @"Starting a Gradle Daemon, 1 busy and 1 incompatible Daemons could not be reused, use --status for details
Observed package id 'add-ons;addon-google_apis-google-14' in inconsistent location 'D:\android-sdk-windows\add-ons\addon-google_apis-google_inc_-14' (Expected 'D:\android-sdk-windows\add-ons\addon-google_apis-google-14')
Observed package id 'add-ons;addon-google_apis-google-14' in inconsistent location 'D:\android-sdk-windows\add-ons\addon-google_apis-google_inc_-14' (Expected 'D:\android-sdk-windows\add-ons\addon-google_apis-google-14')
Incremental java compilation is an incubating feature.
:app:preBuild UP-TO-DATE
:app:preDebugBuild UP-TO-DATE
:app:checkDebugManifest
:app:preReleaseBuild UP-TO-DATE
:app:prepareComAndroidSupportAnimatedVectorDrawable2531Library
:app:prepareComAndroidSupportAppcompatV72531Library
:app:prepareComAndroidSupportSupportCompat2531Library
:app:prepareComAndroidSupportSupportCoreUi2531Library
:app:prepareComAndroidSupportSupportCoreUtils2531Library
:app:prepareComAndroidSupportSupportFragment2531Library
:app:prepareComAndroidSupportSupportMediaCompat2531Library
:app:prepareComAndroidSupportSupportV42531Library
:app:prepareComAndroidSupportSupportVectorDrawable2531Library
:app:prepareOrgXutilsXutils350Library
:app:prepareDebugDependencies
:app:compileDebugAidl UP-TO-DATE
:app:compileDebugRenderscript UP-TO-DATE
:app:generateDebugBuildConfig UP-TO-DATE
:app:generateDebugResValues UP-TO-DATE
:app:generateDebugResources UP-TO-DATE
:app:mergeDebugResources UP-TO-DATE
:app:processDebugManifest UP-TO-DATE
:app:processDebugResources
               : app: prepareComAndroidSupportSupportVectorDrawable2531Library
                 : app: prepareOrgXutilsXutils350Library
                   : app: prepareDebugDependencies
                     : app: compileDebugAidl
                       : app: compileDebugRenderscript
                         : app: generateDebugBuildConfig
                           : app: generateDebugResValues
                             : app: generateDebugResources
                               : app: mergeDebugResources
                                 : app: processDebugManifest
                                   : app: processDebugResources
                                     : app: generateDebugSources
                                       : app: incrementalDebugJavaCompilationSafeguard UP-TO - DATE
:app: javaPreCompileDebug
 : app: compileDebugJavaWithJavac UP-TO - DATE
:app: compileDebugNdk UP-TO - DATE
:app: compileDebugSources UP-TO - DATE
:app: mergeDebugShaders UP-TO - DATE
:app: compileDebugShaders UP-TO - DATE
:app: generateDebugAssets UP-TO - DATE
:app: mergeDebugAssets UP-TO - DATE
:app: transformClassesWithDexForDebug UP-TO - DATE
:app: mergeDebugJniLibFolders UP-TO - DATE
:app: transformNativeLibsWithMergeJniLibsForDebug UP-TO - DATE
:app: transformNativeLibsWithStripDebugSymbolForDebug UP-TO - DATE
:app: processDebugJavaRes UP-TO - DATE
:app: transformResourcesWithMergeJavaResForDebug UP-TO - DATE
:app: validateSigningDebug
 : app: packageDebug
   : app: assembleDebug
     : app: checkReleaseManifest
       : app: prepareReleaseDependencies
         : app: compileReleaseAidl UP-TO - DATE
:app: compileReleaseRenderscript UP-TO - DATE
:app: generateReleaseBuildConfig UP-TO - DATE
:app: generateReleaseResValues UP-TO - DATE
:app: generateReleaseResources UP-TO - DATE
:app: mergeReleaseResources UP-TO - DATE
:app: processReleaseManifest UP-TO - DATE
:app: processReleaseResources UP-TO - DATE
:app: generateReleaseSources UP-TO - DATE
:app: incrementalReleaseJavaCompilationSafeguard UP-TO - DATE
:app: javaPreCompileRelease
 : app: compileReleaseJavaWithJavac UP-TO - DATE
:app: compileReleaseNdk UP-TO - DATE
:app: compileReleaseSources UP-TO - DATE
:app: lintVitalRelease
 : app: mergeReleaseShaders UP-TO - DATE
:app: compileReleaseShaders UP-TO - DATE
:app: generateReleaseAssets UP-TO - DATE
:app: mergeReleaseAssets UP-TO - DATE
:app: transformClassesWithDexForRelease UP-TO - DATE
:app: mergeReleaseJniLibFolders UP-TO - DATE
:app: transformNativeLibsWithMergeJniLibsForRelease UP-TO - DATE
:app: transformNativeLibsWithStripDebugSymbolForRelease UP-TO - DATE
:app: processReleaseJavaRes UP-TO - DATE
:app: transformResourcesWithMergeJavaResForRelease UP-TO - DATE
:app: validateSigningRelease
 : app: packageRelease
   : app: assembleRelease
     : app: assemble
       : app: lint
         Ran lint on variant debug: 45 issues found
Ran lint on variant release: 45 issues found
Wrote HTML report to file:///F:/githubreposity/PackageGame/PackageGame/app/build/reports/lint-results.html
            Wrote XML report to file:///F:/githubreposity/PackageGame/PackageGame/app/build/reports/lint-results.xml
:app: incrementalDebugUnitTestJavaCompilationSafeguard UP-TO - DATE
:app: javaPreCompileDebugUnitTest
 : app: preDebugUnitTestBuild UP-TO - DATE
:app: prepareDebugUnitTestDependencies
 : app: compileDebugUnitTestJavaWithJavac UP-TO - DATE
:app: processDebugUnitTestJavaRes UP-TO - DATE
:app: compileDebugUnitTestSources UP-TO - DATE
:app: mockableAndroidJar
 : app: assembleDebugUnitTest
   : app: testDebugUnitTest UP-TO - DATE
:app: incrementalReleaseUnitTestJavaCompilationSafeguard UP-TO - DATE
:app: javaPreCompileReleaseUnitTest
 : app: preReleaseUnitTestBuild UP-TO - DATE
:app: prepareReleaseUnitTestDependencies
 : app: compileReleaseUnitTestJavaWithJavac UP-TO - DATE
:app: processReleaseUnitTestJavaRes UP-TO - DATE
:app: compileReleaseUnitTestSources UP-TO - DATE
:app: assembleReleaseUnitTest
 : app: testReleaseUnitTest UP-TO - DATE
:app: test UP-TO - DATE
:app: check
 : app: build
   ++++++++++++++copyFileToDailyBuild fromFile = ./build/outputs/apk/开心国王.apk
   ++++++++++++++copyFileToDailyBuild intoFile = ../../ build / release / dailybuild / 开心国王 / 2018.05.24
            ++++++++++++++copyMappingToDailyBuild fromFile = ./ build / outputs / mapping / release / mapping.txt
            ++++++++++++++copyMappingToDailyBuild intoFile = ../../ build / release / dailybuild / 开心国王 / 2018.05.24

BUILD SUCCESSFUL

Total time: 37.859 secs";
            string path = "";
            resultAnalyse(region, ref path);

            Console.WriteLine(path);
            Console.ReadLine();
        }

        private static int resultAnalyse(string region, ref string path)
        {
            //0,表示成功
            //-1,失败
            //1,有任务正在执行
            string pattern = @"(BUILD SUCCESSFUL)|(outputs/apk/.*\.apk)|(BUILD FAILED)|(1 busy and 1 incompatible Daemons could not be reused)";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(region);
            bool success = false;
            while (match.Success)
            {
                if (match.Value.Equals("BUILD SUCCESSFUL"))
                {
                    success = true;
                }
                if (match.Value.Equals("BUILD FAILED"))
                {
                    success = false;
                    return 0;
                }
                if (match.Value.StartsWith("1 busy"))
                {
                    success = false;
                    //return 1;
                }
                if (match.Value.EndsWith(".apk"))
                {
                    path = match.Value.Substring(match.Value.LastIndexOf('/') + 1);
                }
                match = match.NextMatch();

            }
            if (success)
            {
                return 0;
            }
            return -1;
        }
    }

    public static class MoneyExtension
    {
        public static void AddToAmount(this Money money, decimal amountToAdd)
        {
            money.Amount += amountToAdd;
        }
    }
}
