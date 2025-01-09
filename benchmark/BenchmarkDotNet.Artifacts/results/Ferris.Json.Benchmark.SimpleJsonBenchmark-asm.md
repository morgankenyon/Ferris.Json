## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisListMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,199F50041A8
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD1A2B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L14
       cmp       dword ptr [rsp+68],1
       jne       short M00_L01
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFD1A7759B0]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       near ptr M00_L09
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L10
M00_L01:
       mov       ebp,[rsp+68]
       test      ebp,ebp
       jl        near ptr M00_L15
       mov       rdi,[rsp+58]
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       [rdi+8],ebp
       je        short M00_L03
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L08
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       [rsp+58],r14
M00_L03:
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rdi,[rsp+58]
       jmp       near ptr M00_L00
M00_L04:
       mov       rax,[rcx]
       add       rax,10
M00_L05:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L06
       mov       r8,199F5000438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L06
       mov       r8,199F5000418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L12
M00_L06:
       mov       rcx,[rsp+40]
       mov       rdx,199802087E0
       call      qword ptr [7FFD1A776040]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       r8,rax
       test      r8,r8
       je        short M00_L07
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.MixedListTestObj
       cmp       [r8],rcx
       je        short M00_L07
       mov       rdx,rax
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L07:
       mov       rcx,199F50041A8
       mov       rcx,[rcx]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rdx,[r8+8]
       cmp       ecx,[rdx+10]
       jne       near ptr M00_L13
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       call      qword ptr [7FFD1A415BD8]
       jmp       near ptr M00_L02
M00_L09:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L10:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,199802087E0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD1A775A70]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M00_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L04
M00_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FFD1A4A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L06
M00_L13:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L14:
       mov       rcx,199F5001F30
       mov       rdi,[rcx]
       jmp       near ptr M00_L00
M00_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD1A4FED48]
       int       3
M00_L16:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+58],rax
       jmp       near ptr M00_L03
; Total bytes of code 664
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rdi,rdi
       jne       near ptr M01_L11
M01_L00:
       xor       r12d,r12d
M01_L01:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L10
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L10
       mov       rbp,rax
M01_L02:
       mov       [rsp+38],rdi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
M01_L03:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L13
       cmp       r12d,2
       je        near ptr M01_L15
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L17
       mov       r12,[rbp+8]
M01_L04:
       xor       esi,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L08
M01_L05:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,esi
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M01_L07
       test      r15d,r15d
       jne       near ptr M01_L18
       test      r14,r14
       jne       near ptr M01_L19
M01_L06:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD1A554FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L07:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L05
M01_L08:
       mov       rdx,[rsp+50]
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rbx+10],eax
       mov       eax,[rsp+64]
       mov       [rbx+14],eax
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rax,[rsp+38]
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbp
       call      qword ptr [7FFD1A2B6658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L02
M01_L11:
       test      sil,1
       je        near ptr M01_L20
       mov       rcx,199F5000590
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFD1A4AC1C8]
       mov       rdi,rax
       mov       r13d,1
       mov       r12d,2
M01_L12:
       cmp       byte ptr [rsp+0D8],0
       je        near ptr M01_L01
       mov       rcx,rdi
       mov       edx,2A
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A366160]; System.String.EndsWith(Char)
       test      eax,eax
       je        near ptr M01_L01
       mov       r8d,[rdi+8]
       dec       r8d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD1A367240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       mov       r15d,1
       jmp       near ptr M01_L00
M01_L13:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A555050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L14
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD1A556838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L14:
       jmp       near ptr M01_L04
M01_L15:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A555050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L16
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD1A556838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L16:
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD1A556838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,r10
       mov       rdx,rdi
       mov       r8d,r13d
       call      qword ptr [7FFD1A2B6538]
       test      eax,eax
       je        near ptr M01_L07
       mov       r10,[rsp+40]
       test      r14,r14
       je        near ptr M01_L06
M01_L19:
       mov       rcx,r10
       call      qword ptr [7FFD1A61D8F0]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L07
       mov       r10,[rsp+40]
       jmp       near ptr M01_L06
M01_L20:
       mov       r12d,1
       jmp       near ptr M01_L12
; Total bytes of code 802
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1D8
       vzeroupper
       lea       rbp,[rsp+210]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-40],rax
       mov       [rbp-1E0],rsp
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L85
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       r14d,r14d
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,r14d
       mov       r15,[rsi+rcx*8+10]
       mov       r13,[r15]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L87
       mov       rcx,r15
       cmp       qword ptr [rcx+18],0
       je        near ptr M02_L86
       mov       rcx,[r15+18]
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L79
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD1A543280]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
M02_L05:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L78
       mov       rcx,r15
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L77
M02_L06:
       mov       rcx,[r15+38]
       mov       rax,[rcx+18]
M02_L07:
       mov       rdx,rax
       mov       [rbp-160],rdx
       test      r12,r12
       je        near ptr M02_L75
       mov       rcx,19980200020
       cmp       rdx,rcx
       jne       near ptr M02_L33
M02_L08:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,199F5001EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD1A539EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M02_L95
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L09:
       mov       [rbp-48],r8
       mov       [rbp-40],eax
       xor       edx,edx
       mov       [rbp-50],edx
       mov       byte ptr [rbp-4C],0
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L96
       mov       rdx,19980208814
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-50]
       inc       edx
       mov       [rbp-50],edx
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rdx
       jne       near ptr M02_L97
M02_L10:
       mov       r13,[r15+8]
       test      r13,r13
       je        near ptr M02_L28
M02_L11:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L98
M02_L12:
       test      r13,r13
       je        near ptr M02_L98
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M02_L98
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD1A415B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-50]
       add       edx,[r13+8]
       mov       [rbp-50],edx
M02_L13:
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L99
       mov       rdx,1998020887C
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-50]
       add       edx,3
       mov       [rbp-50],edx
M02_L14:
       mov       [rbp-0D0],r12
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L27
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L26
       xor       r8d,r8d
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D0]
       cmp       qword ptr [rbp-0D8],0
       jne       short M02_L15
       mov       r8,[r8]
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D8]
       cmp       qword ptr [rbp-0D8],0
       je        near ptr M02_L88
M02_L15:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L89
M02_L16:
       mov       r15,rcx
M02_L17:
       test      r15,r15
       je        short M02_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L90
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD1A415B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[r15+8]
       mov       [rbp-50],ecx
M02_L18:
       xor       ecx,ecx
       mov       [rbp-0D8],rcx
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L102
       mov       rcx,19980208814
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M02_L19:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rax,[rbp-48]
       mov       [rbp-158],rax
       mov       [rbp-150],ecx
       lea       rcx,[rbp-158]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r15,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      r15,r15
       je        near ptr M02_L22
       mov       rcx,199F5001EE8
       mov       r12,[rcx]
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-0E4],eax
       mov       rcx,7FFD1A2A5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L91
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-0EC],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-0E4]
       cmp       edx,r10d
       jbe       near ptr M02_L21
       mov       dword ptr [rbp-0E8],1
       mov       edx,10
       shlx      edx,edx,r10d
       cmp       [r15+8],edx
       jne       near ptr M02_L80
       mov       [rbp-0E4],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-198],r9
       mov       r11,[r9]
       mov       [rbp-1A0],r11
       mov       rcx,r9
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-198]
       mov       [rdx+8],ecx
       mov       rax,[rbp-1A0]
       test      rax,rax
       mov       [rbp-1A0],rax
       mov       eax,[rbp-0E8]
       mov       r10d,[rbp-0E4]
       jne       near ptr M02_L92
M02_L21:
       mov       rcx,199F50005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M02_L115
M02_L22:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L29
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,19980200C60
       call      qword ptr [7FFD1A366DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M02_L83
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L83
       mov       ecx,[rbx+8]
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L84
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       rcx,19980208A9C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r15+0E]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFD1A415B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbx+8]
       inc       eax
       cdqe
       lea       rax,[r15+rax*2+0C]
       mov       rcx,19980208AB4
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       rax,r15
M02_L25:
       add       rsp,1D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L26:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L101
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A3643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-60]
       mov       r11,7FFD1A2206B8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L17
M02_L27:
       lea       rcx,[rbp-60]
       mov       r8,[rbp-0D0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD1A8DC930]
       jmp       near ptr M02_L18
M02_L28:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0B8],xmm0
       mov       rdx,[r15+48]
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFD1A556B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0B8]
       vmovups   [rbp-0C8],xmm0
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFD1A556BE0]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L11
M02_L29:
       mov       rcx,rdi
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L30:
       test      rcx,rcx
       je        near ptr M02_L81
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD1A543280]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L31:
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rcx
       jne       near ptr M02_L122
       mov       rcx,rax
       call      qword ptr [7FFD1A4264F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M02_L32:
       mov       [rbp-168],rax
       jmp       short M02_L34
M02_L33:
       mov       rcx,19980208848
       cmp       rdx,rcx
       je        near ptr M02_L08
       mov       rcx,19980208890
       call      qword ptr [7FFD1A2AA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M02_L131
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,199F5001F00
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L121
       mov       rcx,r15
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L120
       jmp       near ptr M02_L30
M02_L34:
       cmp       qword ptr [rbp-168],0
       je        near ptr M02_L53
       mov       rcx,[rbp-168]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rcx],rdx
       jne       near ptr M02_L53
       jmp       near ptr M02_L44
M02_L35:
       mov       rdx,[rbp-168]
       add       rdx,8
       mov       ecx,[rdx+10]
       test      ecx,ecx
       je        near ptr M02_L54
       mov       rax,[rdx]
       mov       eax,[rax+10]
       inc       eax
       cmp       ecx,eax
       je        near ptr M02_L54
       mov       rax,[rdx+8]
       mov       r8,rax
       mov       [rbp-170],r8
       mov       rcx,r8
       call      System.Object.GetType()
       mov       rcx,rax
       mov       [rbp-1C8],rcx
       mov       rax,rcx
       mov       rdx,19980200020
       cmp       rax,rdx
       je        near ptr M02_L38
       mov       rdx,19980208848
       cmp       rax,rdx
       je        near ptr M02_L38
       mov       rcx,rax
       call      qword ptr [7FFD1A2B7330]; System.RuntimeType.GetBaseType()
       mov       rdx,199802021B8
       cmp       rax,rdx
       jne       near ptr M02_L60
       mov       rcx,[rbp-1C8]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-128]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD1A2B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-118],0
       je        near ptr M02_L37
       cmp       dword ptr [rbp-118],1
       jne       near ptr M02_L40
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,rax
       mov       [rbp-1B8],rcx
       mov       r8,[rbp-120]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-1B8]
M02_L36:
       mov       rdx,[rbp-170]
       call      qword ptr [7FFD1A7759B0]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       near ptr M02_L43
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L44
M02_L37:
       mov       rcx,199F5001F30
       mov       rcx,[rcx]
       jmp       short M02_L36
M02_L38:
       mov       rcx,[rbp-170]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,19980208808
       mov       r8,19980208808
       call      qword ptr [7FFD1A366B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       short M02_L39
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L44
M02_L39:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L44
M02_L40:
       lea       rdx,[rbp-128]
       mov       r8d,[rbp-118]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD1A52FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-118]
       mov       [rbp-114],ecx
       mov       rcx,[rbp-128]
       jmp       near ptr M02_L36
M02_L41:
       mov       ecx,[rax+14]
       mov       rdx,[rax]
       cmp       ecx,[rdx+14]
       jne       near ptr M02_L64
M02_L42:
       mov       rcx,[rax]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+8],rcx
       jmp       near ptr M02_L65
M02_L43:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L44:
       mov       rax,[rbp-168]
       add       rax,8
       mov       r8,[rax]
       mov       ecx,[rax+14]
       cmp       ecx,[r8+14]
       jne       short M02_L41
       mov       ecx,[rax+10]
       cmp       ecx,[r8+10]
       jae       short M02_L42
       lea       rcx,[rax+8]
       mov       r10,[r8+8]
       mov       [rbp-1C0],rax
       mov       r9d,[rax+10]
       cmp       r9d,[r10+8]
       jae       near ptr M02_L55
       mov       edx,r9d
       mov       rdx,[r10+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-1C0]
       inc       dword ptr [rax+10]
       jmp       near ptr M02_L35
M02_L45:
       mov       rcx,[rbp-168]
       mov       r11,7FFD1A2206A0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L59
       jmp       near ptr M02_L65
M02_L46:
       mov       rdx,[rbp-168]
       add       rdx,8
       mov       ecx,[rdx+10]
       test      ecx,ecx
       je        near ptr M02_L54
       mov       rax,[rdx]
       mov       eax,[rax+10]
       inc       eax
       cmp       ecx,eax
       je        near ptr M02_L54
       mov       rax,[rdx+8]
       mov       rdx,rax
M02_L47:
       mov       rax,rdx
       mov       [rbp-170],rax
       mov       rcx,rax
       call      System.Object.GetType()
       mov       rcx,rax
       mov       [rbp-1D0],rcx
       mov       rax,rcx
       mov       rdx,19980200020
       cmp       rax,rdx
       je        near ptr M02_L58
       mov       rdx,19980208848
       cmp       rax,rdx
       je        near ptr M02_L58
       mov       rcx,rax
       call      qword ptr [7FFD1A2B7330]; System.RuntimeType.GetBaseType()
       mov       rdx,199802021B8
       cmp       rax,rdx
       jne       near ptr M02_L56
       mov       rcx,[rbp-1D0]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-128]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD1A2B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-118],0
       je        near ptr M02_L57
       cmp       dword ptr [rbp-118],1
       jne       short M02_L49
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,rax
       mov       [rbp-1B8],rcx
       mov       r8,[rbp-120]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-1B8]
M02_L48:
       mov       rdx,[rbp-170]
       call      qword ptr [7FFD1A7759B0]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       mov       ecx,[r8+8]
       cmp       ecx,r10d
       jbe       short M02_L52
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L53
M02_L49:
       lea       rdx,[rbp-128]
       mov       r8d,[rbp-118]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD1A52FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-118]
       mov       [rbp-114],ecx
       mov       rcx,[rbp-128]
       jmp       short M02_L48
M02_L50:
       mov       rcx,[rax]
       cmp       r10d,[rcx+14]
       jne       near ptr M02_L64
M02_L51:
       mov       rcx,[rax]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+8],rcx
       jmp       near ptr M02_L65
M02_L52:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L53:
       mov       rax,[rbp-168]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rcx
       jne       near ptr M02_L45
       mov       rax,[rbp-168]
       add       rax,8
       mov       r8,[rax]
       mov       r10d,[rax+14]
       cmp       r10d,[r8+14]
       jne       short M02_L50
       mov       r9d,[rax+10]
       cmp       r9d,[r8+10]
       jae       short M02_L51
       mov       [rbp-1C0],rax
       lea       rcx,[rax+8]
       mov       r10,[r8+8]
       cmp       r9d,[r10+8]
       jae       short M02_L55
       mov       edx,r9d
       mov       rdx,[r10+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-1C0]
       inc       dword ptr [rax+10]
       jmp       near ptr M02_L46
M02_L54:
       call      qword ptr [7FFD1A4FF000]
       int       3
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L56:
       mov       rcx,[rbp-170]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       near ptr M02_L63
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L53
M02_L57:
       mov       rcx,199F5001F30
       mov       rcx,[rcx]
       jmp       near ptr M02_L48
M02_L58:
       mov       rcx,[rbp-170]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,19980208808
       mov       r8,19980208808
       call      qword ptr [7FFD1A366B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       near ptr M02_L62
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L53
M02_L59:
       mov       rcx,[rbp-168]
       mov       r11,7FFD1A2206A8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M02_L47
M02_L60:
       mov       rcx,[rbp-170]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       short M02_L61
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L44
M02_L61:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L44
M02_L62:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L53
M02_L63:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L53
M02_L64:
       call      qword ptr [7FFD1A4FEFE8]
       int       3
M02_L65:
       mov       rdx,[rbp-168]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L66
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rdx
       jne       near ptr M02_L123
M02_L66:
       mov       rdx,r12
       mov       rcx,19980200C60
       call      qword ptr [7FFD1A366DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       r12,rax
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,199F5001EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD1A539EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M02_L124
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L67:
       mov       [rbp-48],rdx
       mov       [rbp-40],eax
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L125
       mov       rcx,19980208814
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L126
M02_L68:
       mov       rcx,r15
       call      qword ptr [7FFD1A61D888]; System.Reflection.RuntimePropertyInfo.get_Name()
       mov       rdx,rax
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L127
M02_L69:
       test      rdx,rdx
       je        near ptr M02_L127
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,r8d
       mov       r15d,[rdx+8]
       cmp       r15d,eax
       ja        near ptr M02_L127
       add       rdx,0C
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFD1A415B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rbp-50]
       mov       [rbp-50],r15d
M02_L70:
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       edx,3
       jb        near ptr M02_L128
       mov       r8,199802088C4
       mov       eax,[r8]
       mov       edx,[r8+2]
       mov       [rcx],eax
       mov       [rcx+2],edx
       mov       r8d,[rbp-50]
       add       r8d,3
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L129
M02_L71:
       test      r12,r12
       je        near ptr M02_L129
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L82
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M02_L129
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD1A415B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[r12+8]
       mov       [rbp-50],ecx
M02_L72:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L130
       mov       rcx,199802088E4
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M02_L73:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L74
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L74:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L75:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,19980208808
       mov       r8,19980208820
       call      qword ptr [7FFD1A366B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L76
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L76:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L77:
       mov       rcx,[r15+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-180],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rbp-180]
       mov       [rbp-80],rdx
       mov       [rbp-78],rax
       lea       rdx,[rbp-0A0]
       mov       [rsp+20],rdx
       mov       edx,[r15+50]
       lea       rcx,[rbp-80]
       lea       r8,[rbp-88]
       lea       r9,[rbp-90]
       call      qword ptr [7FFD1A5C5F38]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rbp-98]
       mov       [rbp-0A8],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       mov       r9,[r15+30]
       mov       rcx,rax
       mov       rdx,[rbp-0A8]
       mov       r8d,[rbp-0A0]
       call      qword ptr [7FFD1A557B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r15+38]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L78:
       mov       rcx,r15
       mov       rax,[r13+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M02_L07
M02_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A77ECD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A36F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L80:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A8752D8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A214000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD1A36F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L81:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A77ECD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A36F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L82:
       call      qword ptr [7FFD1A4FE9D0]
       int       3
M02_L83:
       mov       rcx,19980208A90
       mov       rdx,19980208AA8
       call      qword ptr [7FFD1A366B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M02_L25
M02_L84:
       call      qword ptr [7FFD1A4FEF40]
       int       3
M02_L85:
       mov       rcx,199F5001F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L86:
       xor       ecx,ecx
       jmp       near ptr M02_L04
M02_L87:
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r13+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L05
M02_L88:
       xor       r15d,r15d
       jmp       near ptr M02_L17
M02_L89:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L16
M02_L90:
       lea       rcx,[rbp-60]
       mov       rdx,r15
       call      qword ptr [7FFD1A4858F0]
       jmp       near ptr M02_L18
M02_L91:
       mov       rcx,r12
       call      qword ptr [7FFD1A52D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L92:
       mov       rcx,[r12+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M02_L162
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-0E8],eax
       jne       short M02_L94
       mov       rcx,r12
       mov       [rbp-0E4],r10d
       mov       edx,r10d
       call      qword ptr [7FFD1A52D7E8]
       mov       r9,rax
M02_L93:
       mov       r9,[r9+8]
       mov       [rbp-1A8],r9
       mov       rcx,7FFD1A2A5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A2A5C38],0
       je        near ptr M02_L103
       call      qword ptr [7FFD1A36DC98]
       mov       edx,eax
       mov       [rbp-104],edx
       jmp       near ptr M02_L106
M02_L94:
       mov       [rbp-0E4],r10d
       jmp       short M02_L93
M02_L95:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L09
M02_L96:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       je        near ptr M02_L10
M02_L97:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L12
M02_L98:
       lea       rcx,[rbp-60]
       mov       rdx,r13
       call      qword ptr [7FFD1A485848]
       jmp       near ptr M02_L13
M02_L99:
       lea       rcx,[rbp-60]
       mov       rdx,19980208870
       call      qword ptr [7FFD1A4858F0]
       jmp       near ptr M02_L14
M02_L100:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485938]
M02_L101:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A3643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L82
       mov       r9,[rbp-48]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rbp-40]
       sub       r8d,edx
       xor       edx,edx
       mov       [rbp-148],r9
       mov       [rbp-140],r8d
       mov       [rbp-158],rdx
       xor       edx,edx
       mov       [rbp-150],edx
       mov       rdx,[rbp-60]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-148]
       lea       r9,[rbp-158]
       lea       r8,[rbp-0E0]
       mov       r11,7FFD1A2206C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L100
       mov       ecx,[rbp-50]
       add       ecx,[rbp-0E0]
       mov       [rbp-50],ecx
       jmp       near ptr M02_L18
M02_L102:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
       jmp       near ptr M02_L19
M02_L103:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-108],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-108]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L104
       call      qword ptr [7FFD1A8AF390]
       mov       edx,eax
       jmp       short M02_L105
M02_L104:
       mov       edx,ecx
       sar       edx,10
M02_L105:
       mov       [rbp-104],edx
M02_L106:
       mov       rcx,7FFD1A2A5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-104]
       xor       edx,edx
       div       dword ptr [7FFD1A2A5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L113
M02_L107:
       cmp       eax,[r8+8]
       jae       near ptr M02_L162
       mov       [rbp-0FC],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-1B0],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-10C],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1B0]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-110],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L109
       test      r10d,r10d
       jne       short M02_L110
       xor       edx,edx
       mov       [rax+14],edx
M02_L108:
       movsxd    rdx,r10d
       mov       r8,[rbp-1A0]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-110]
       inc       ecx
       mov       rax,[rbp-1B0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-10C],1
M02_L109:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-10C]
       test      ecx,ecx
       je        short M02_L111
       mov       r8d,1
       jmp       short M02_L114
M02_L110:
       jmp       short M02_L108
M02_L111:
       mov       eax,[rbp-0FC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-1A8]
       cmp       [rcx+8],r8d
       jne       short M02_L112
       xor       r8d,r8d
M02_L112:
       mov       edx,[rbp-100]
       inc       edx
       mov       eax,r8d
M02_L113:
       mov       r8,[rbp-1A8]
       mov       [rbp-100],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L107
       xor       r8d,r8d
M02_L114:
       mov       eax,r8d
       mov       [rbp-0EC],eax
       mov       eax,[rbp-0E8]
       mov       r10d,[rbp-0E4]
       jmp       near ptr M02_L21
M02_L115:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-0EC]
       cmp       dword ptr [r15+8],0
       mov       [rbp-0E4],edx
       mov       [rbp-0E8],r8d
       mov       [rbp-188],r10
       mov       [rbp-0EC],eax
       je        near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0F0],eax
       mov       edx,[r15+8]
       mov       [rbp-0F4],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-188]
       mov       r8d,[rbp-0F0]
       mov       r9d,[rbp-0F4]
       mov       edx,3
       call      qword ptr [7FFD1A417678]
       mov       eax,[rbp-0E8]
       test      [rbp-0EC],eax
       mov       [rbp-0E8],eax
       jne       near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rbp-188]
       mov       [rbp-190],rdx
       mov       [rbp-0F8],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-0E8]
       test      r12d,r12d
       jne       short M02_L116
       mov       rcx,[rbp-190]
       mov       edx,[rbp-0F8]
       mov       r8d,0FFFFFFFF
       jmp       short M02_L117
M02_L116:
       mov       rcx,[rbp-190]
       mov       edx,[rbp-0F8]
       mov       r8d,[rbp-0E4]
M02_L117:
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L118
       mov       eax,1
       jmp       short M02_L119
M02_L118:
       xor       eax,eax
M02_L119:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r15d
       call      qword ptr [7FFD1A52E2B0]
       jmp       near ptr M02_L22
M02_L120:
       xor       ecx,ecx
       jmp       near ptr M02_L30
M02_L121:
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r13+58]
       call      qword ptr [rax+38]
       jmp       near ptr M02_L31
M02_L122:
       mov       rcx,rax
       mov       r11,7FFD1A220698
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L123:
       mov       rcx,rax
       mov       r11,7FFD1A2206B0
       call      qword ptr [r11]
       jmp       near ptr M02_L66
M02_L124:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L67
M02_L125:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       je        near ptr M02_L68
M02_L126:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L69
M02_L127:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485848]
       jmp       near ptr M02_L70
M02_L128:
       lea       rcx,[rbp-60]
       mov       rdx,199802088B8
       call      qword ptr [7FFD1A4858F0]
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L71
M02_L129:
       lea       rcx,[rbp-60]
       mov       rdx,r12
       call      qword ptr [7FFD1A485848]
       jmp       near ptr M02_L72
M02_L130:
       lea       rcx,[rbp-60]
       mov       rdx,199802088D8
       call      qword ptr [7FFD1A4858F0]
       jmp       near ptr M02_L73
M02_L131:
       mov       rcx,[rbp-160]
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       mov       rcx,199802021B8
       cmp       rax,rcx
       jne       near ptr M02_L133
       mov       rcx,[rbp-160]
       mov       edx,1C
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L133
       mov       rcx,[rbp-160]
       mov       edx,1C
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r12
       call      qword ptr [7FFD1A7759B0]
       mov       r12,rax
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r12
       mov       rcx,19980208808
       mov       r8,199802088F0
       call      qword ptr [7FFD1A366B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L132
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L132:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L133:
       mov       rcx,19980208910
       mov       rax,[rbp-160]
       cmp       rax,rcx
       je        near ptr M02_L134
       mov       rcx,19980208610
       cmp       rax,rcx
       je        near ptr M02_L134
       mov       rcx,19980204FE8
       cmp       rax,rcx
       je        near ptr M02_L134
       mov       rcx,19980208938
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,19980205F80
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,19980208960
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,19980208988
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,199802089B0
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,199802089D8
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,19980204BB0
       cmp       rax,rcx
       je        short M02_L134
       mov       rcx,19980208A00
       cmp       rax,rcx
       jne       near ptr M02_L140
M02_L134:
       lea       rcx,[rbp-60]
       mov       edx,3
       mov       r8d,2
       call      qword ptr [7FFD1A4856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L135
       mov       rcx,19980208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L136
M02_L135:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
M02_L136:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,2
       jb        short M02_L137
       mov       rcx,199802088FC
       mov       eax,[rcx]
       mov       [rdx],eax
       mov       ecx,[rbp-50]
       add       ecx,2
       mov       [rbp-50],ecx
       jmp       short M02_L138
M02_L137:
       lea       rcx,[rbp-60]
       mov       rdx,199802088F0
       call      qword ptr [7FFD1A4858F0]
M02_L138:
       lea       rcx,[rbp-60]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5F7978]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L139
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L139:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L140:
       mov       rdx,19980208A28
       cmp       rax,rdx
       jne       near ptr M02_L142
       mov       rdx,r12
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD1A364408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm0,dword ptr [rax]
       vmovss    dword ptr [rbp-64],xmm0
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       mov       rcx,199F5000428
       mov       rcx,[rcx]
       vmovss    xmm0,dword ptr [rbp-64]
       vmovss    dword ptr [rbp-12C],xmm0
       call      qword ptr [7FFD1A48F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovss    xmm0,dword ptr [rbp-12C]
       mov       rdx,19980208A50
       call      qword ptr [7FFD1A4AFA98]
       mov       r9,rax
       mov       rdx,r12
       mov       rcx,19980208808
       mov       r8,199802088F0
       call      qword ptr [7FFD1A366B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L141
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L141:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L142:
       mov       rdx,19980205740
       cmp       rax,rdx
       jne       near ptr M02_L144
       mov       rdx,r12
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD1A364408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    qword ptr [rbp-70],xmm0
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,199F5000428
       mov       rcx,[rcx]
       vmovsd    xmm0,qword ptr [rbp-70]
       vmovsd    qword ptr [rbp-138],xmm0
       call      qword ptr [7FFD1A48F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovsd    xmm0,qword ptr [rbp-138]
       mov       rdx,19980208A50
       call      qword ptr [7FFD1A4AFA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,19980208808
       mov       r8,199802088F0
       call      qword ptr [7FFD1A366B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L143
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L143:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L144:
       mov       rcx,19980203C58
       cmp       rax,rcx
       jne       near ptr M02_L146
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       cmp       [rax],al
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFD1A3672A0]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,19980208808
       mov       r8,199802088F0
       call      qword ptr [7FFD1A366B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L145
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L145:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L146:
       mov       rdx,19980208A68
       cmp       rax,rdx
       jne       near ptr M02_L154
       mov       rdx,r12
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD1A364408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,199F5000428
       mov       r8,[r8]
       mov       rdx,199802067B8
       call      qword ptr [7FFD1A955A70]
       mov       r12,rax
       lea       rcx,[rbp-60]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L147
       mov       rcx,19980208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L148
M02_L147:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
M02_L148:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L149
       mov       rcx,1998020887C
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-50]
       add       ecx,3
       mov       [rbp-50],ecx
       jmp       short M02_L150
M02_L149:
       lea       rcx,[rbp-60]
       mov       rdx,19980208870
       call      qword ptr [7FFD1A4858F0]
M02_L150:
       lea       rcx,[rbp-60]
       mov       rdx,r12
       call      qword ptr [7FFD1A485830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L151
       mov       rcx,19980208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L152
M02_L151:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
M02_L152:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L153
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L153:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L154:
       lea       rcx,[rbp-60]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L155
       mov       rcx,19980208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L156
M02_L155:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
M02_L156:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L157
       mov       rcx,1998020887C
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-50]
       add       ecx,3
       mov       [rbp-50],ecx
       jmp       short M02_L158
M02_L157:
       lea       rcx,[rbp-60]
       mov       rdx,19980208870
       call      qword ptr [7FFD1A4858F0]
M02_L158:
       lea       rcx,[rbp-60]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5F7978]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L82
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L159
       mov       rcx,19980208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L160
M02_L159:
       lea       rcx,[rbp-60]
       mov       rdx,19980208808
       call      qword ptr [7FFD1A4858F0]
M02_L160:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD1A485740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L161
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L161:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A41E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L162:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+210]
       mov       rdx,[rbp-168]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L163
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rcx
       je        short M02_L163
       mov       rcx,rax
       mov       r11,7FFD1A2206B0
       call      qword ptr [r11]
M02_L163:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 8256
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD1A364348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M03_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M03_L05
M03_L00:
       mov       rax,rbx
M03_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD1A214000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A5266E8]
       int       3
M03_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M03_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD1A876A60]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD1A77C648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD1A876AF0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD1A77C648]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rcx,19980203C58
       cmp       rsi,rcx
       jne       short M03_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220790
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L07:
       mov       rcx,19980208848
       cmp       rsi,rcx
       jne       short M03_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220788
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L08:
       mov       rcx,199802089B0
       cmp       rsi,rcx
       jne       short M03_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220780
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L09:
       mov       rcx,19980208988
       cmp       rsi,rcx
       jne       short M03_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220778
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,19980208910
       cmp       rsi,rcx
       jne       short M03_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220770
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L11:
       mov       rcx,19980208610
       cmp       rsi,rcx
       jne       short M03_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220768
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L12:
       mov       rcx,19980204FE8
       cmp       rsi,rcx
       jne       short M03_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220760
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L13:
       mov       rcx,19980208938
       cmp       rsi,rcx
       jne       short M03_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220758
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,19980205F80
       cmp       rsi,rcx
       jne       short M03_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220750
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,19980208960
       cmp       rsi,rcx
       jne       short M03_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220748
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L16:
       mov       rcx,19980208A28
       cmp       rsi,rcx
       jne       short M03_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220740
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L17:
       mov       rcx,19980205740
       cmp       rsi,rcx
       jne       short M03_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220738
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L18:
       mov       rcx,199802089D8
       cmp       rsi,rcx
       jne       short M03_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD1A220730
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L19:
       mov       rcx,19980208A68
       cmp       rsi,rcx
       jne       short M03_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220728
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L20:
       mov       rcx,19980200020
       cmp       rsi,rcx
       jne       short M03_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A220720
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M03_L21:
       mov       rcx,199802021B8
       cmp       rsi,rcx
       je        near ptr M03_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD1A220718
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M04_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       jne       short M04_L00
M04_L03:
       jmp       qword ptr [7FFD1A3643A8]
; Total bytes of code 69
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M05_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,2D8
       vzeroupper
       xor       eax,eax
       mov       [rsp+128],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+130],xmm4
       vmovdqa   xmmword ptr [rsp+140],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M05_L01:
       vmovdqa   xmmword ptr [rsp+rax+2D0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2F0],xmm4
       add       rax,30
       jne       short M05_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M05_L116
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+240]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD1A2B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+250],0
       je        near ptr M05_L110
       cmp       dword ptr [rsp+250],1
       jne       near ptr M05_L57
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+248]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M05_L02:
       mov       rcx,199F5004E90
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M05_L55
M05_L03:
       mov       rcx,199F5004E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M05_L05
M05_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD1A77C258]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       [rsp+118],rax
       cmp       [rbx],r14
       jne       near ptr M05_L117
       mov       rcx,rbx
       jmp       near ptr M05_L76
M05_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,199F5004E88
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A7780D8
       mov       [r12+18],rcx
       mov       rcx,199F5004E98
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       near ptr M05_L04
M05_L06:
       mov       r12d,1
       xor       ebx,ebx
       mov       [rsp+110],rbx
       xor       eax,eax
       mov       [rsp+108],rax
       xor       r10d,r10d
       mov       [rsp+100],r10
       xor       r9d,r9d
       mov       [rsp+0F8],r9
M05_L07:
       mov       r11,rdi
       mov       r8d,ebp
       test      r8d,r8d
       je        near ptr M05_L120
       movzx     ecx,word ptr [r11]
       cmp       ecx,7B
       je        near ptr M05_L54
       cmp       ecx,7D
       je        near ptr M05_L51
       cmp       ecx,22
       jne       short M05_L09
       cmp       r12d,9
       jne       near ptr M05_L48
M05_L08:
       mov       edx,7
       jmp       short M05_L10
M05_L09:
       cmp       ecx,3A
       jne       near ptr M05_L13
       mov       edx,9
M05_L10:
       mov       ecx,edx
       mov       [rsp+23C],ecx
       cmp       ecx,6
       je        short M05_L11
       cmp       ecx,7
       jne       near ptr M05_L75
M05_L11:
       cmp       ecx,6
       jne       near ptr M05_L77
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+210],xmm0
       cmp       r8d,1
       jb        near ptr M05_L109
       add       r11,2
       sub       r8d,1
       mov       [rsp+50],r11
       mov       [rsp+144],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD1A5F6148]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+224],eax
       cmp       eax,[rsp+144]
       ja        near ptr M05_L109
       mov       rcx,[rsp+50]
       mov       [rsp+210],rcx
       mov       [rsp+218],eax
       lea       rcx,[rsp+210]
       call      qword ptr [7FFD1A41C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+48],rax
       mov       edx,[rsp+224]
       add       edx,2
       mov       [rsp+140],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+90],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+140]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+90]
M05_L12:
       mov       r8,rax
       jmp       short M05_L15
M05_L13:
       cmp       ecx,2C
       jne       short M05_L16
       mov       edx,8
       jmp       near ptr M05_L10
M05_L14:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+23C]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
M05_L15:
       mov       rdx,r8
       mov       [rsp+0F0],rdx
       mov       r8d,[rdx+10]
       mov       [rsp+2D4],r8d
       mov       r11d,[rdx+14]
       mov       [rsp+2D0],r11d
       cmp       r8d,2
       je        near ptr M05_L89
       jmp       short M05_L17
M05_L16:
       cmp       ecx,5B
       jne       short M05_L18
       mov       edx,0A
       jmp       near ptr M05_L10
M05_L17:
       cmp       r8d,8
       je        short M05_L19
       jmp       near ptr M05_L49
M05_L18:
       cmp       ecx,5D
       jne       near ptr M05_L111
       mov       edx,0B
       jmp       near ptr M05_L10
M05_L19:
       cmp       r12d,7
       jne       near ptr M05_L30
       mov       rax,[rsp+108]
       test      rax,rax
       je        near ptr M05_L50
       cmp       dword ptr [rax+10],6
       jne       near ptr M05_L50
       mov       [rsp+108],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       mov       rax,[rsp+108]
       je        near ptr M05_L50
       mov       r10,[rsp+100]
       test      r10,r10
       je        near ptr M05_L29
       mov       [rsp+100],r10
       cmp       dword ptr [r10+10],9
       jne       near ptr M05_L50
       mov       r9,[rsp+0F8]
       test      r9,r9
       je        near ptr M05_L28
       cmp       dword ptr [r9+10],7
       jne       near ptr M05_L27
       mov       [rsp+0F8],r9
       movzx     ebx,byte ptr [r9+18]
M05_L20:
       test      ebx,ebx
       je        near ptr M05_L50
       mov       [rsp+0B0],rcx
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L26
       mov       r15,offset MT_System.String
       cmp       [rbx],r15
       mov       [rsp+108],rax
       jne       near ptr M05_L102
M05_L21:
       mov       r15,[rsp+118]
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD1A36EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M05_L25
       mov       rbx,[rax]
       xor       ecx,ecx
       mov       [rsp+180],ecx
       mov       [rsp+188],ecx
       mov       [rsp+194],ecx
       mov       [rsp+198],rcx
       mov       byte ptr [rsp+1A0],0
       mov       byte ptr [rsp+1A8],0
       mov       byte ptr [rsp+1B0],0
       mov       [rsp+1B8],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+1C0],xmm0
       mov       [rsp+1D0],rcx
       mov       [rsp+1D8],rcx
       mov       [rsp+1E0],ecx
       mov       [rsp+1E8],ecx
       mov       [rsp+1F0],rcx
       mov       rax,[rsp+0F8]
       cmp       byte ptr [rax+18],0
       je        short M05_L24
       mov       [rsp+0F8],rax
       mov       rdx,[rax+8]
       mov       [rsp+88],rdx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M05_L124
       mov       rcx,rbx
       cmp       qword ptr [rcx+38],0
       je        near ptr M05_L31
M05_L22:
       mov       rcx,[rbx+38]
       mov       r8,[rcx+18]
M05_L23:
       mov       r10,r8
       mov       [rsp+78],r10
       mov       rcx,19980200020
       cmp       r10,rcx
       je        near ptr M05_L80
       jmp       near ptr M05_L86
M05_L24:
       mov       [rsp+0F8],rax
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L25:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L26:
       mov       [rsp+108],rax
       jmp       near ptr M05_L21
M05_L27:
       mov       r10,[rsp+100]
       mov       r15,[rsp+118]
       jmp       near ptr M05_L83
M05_L28:
       mov       r10,[rsp+100]
       mov       r15,[rsp+118]
       jmp       near ptr M05_L83
M05_L29:
       mov       [rsp+100],r10
       jmp       near ptr M05_L50
M05_L30:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L31:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+68],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+68]
       mov       [rsp+170],rdx
       mov       [rsp+178],rax
       lea       rdx,[rsp+150]
       mov       [rsp+20],rdx
       mov       edx,[rbx+50]
       lea       rcx,[rsp+170]
       lea       r8,[rsp+168]
       lea       r9,[rsp+160]
       call      qword ptr [7FFD1A5C5F38]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+158]
       mov       [rsp+148],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+70],rax
       mov       r9,[rbx+30]
       mov       rcx,rax
       mov       rdx,[rsp+148]
       mov       r8d,[rsp+150]
       call      qword ptr [7FFD1A557B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[rbx+38]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L22
M05_L32:
       cmp       r8d,0A
       je        short M05_L34
M05_L33:
       mov       r8d,[rsp+2D4]
       cmp       r8d,5
       je        near ptr M05_L85
       cmp       r8d,8
       je        near ptr M05_L73
       cmp       r8d,3
       je        near ptr M05_L73
       cmp       r8d,6
       jne       near ptr M05_L78
       jmp       near ptr M05_L84
M05_L34:
       cmp       r12d,9
       jne       short M05_L33
       mov       [rsp+108],rax
       mov       rcx,rax
       call      qword ptr [7FFD1A7759F8]; Ferris.Json.JsonTransformer.IsValidPropertyNameToken(Ferris.Json.TokenInfo)
       test      eax,eax
       je        near ptr M05_L43
       mov       rax,[rsp+100]
       test      rax,rax
       je        near ptr M05_L169
       mov       [rsp+100],rax
       xor       ecx,ecx
       cmp       dword ptr [rax+10],9
       sete      cl
M05_L35:
       test      ecx,ecx
       je        near ptr M05_L42
       mov       r8,[rsp+108]
       mov       rdx,[r8+8]
       mov       r10,rdx
       test      r10,r10
       je        short M05_L36
       mov       rcx,offset MT_System.String
       cmp       [r10],rcx
       jne       near ptr M05_L108
M05_L36:
       mov       r15,[rsp+118]
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,r10
       call      qword ptr [7FFD1A36EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M05_L41
       mov       rcx,[rax]
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M05_L170
       cmp       [rcx],cl
       call      qword ptr [7FFD1A635860]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rax,[rax+18]
       cmp       [rax],r14
       jne       near ptr M05_L171
       mov       [rsp+0E8],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2AA518]; System.RuntimeType.get_IsGenericType()
M05_L37:
       test      eax,eax
       je        near ptr M05_L98
       mov       rdx,[rsp+0E8]
       mov       r8,[rdx]
       mov       [rsp+120],r8
       cmp       r8,r14
       jne       near ptr M05_L172
       mov       [rsp+0E8],rdx
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2AA568]; System.RuntimeType.GetGenericTypeDefinition()
M05_L38:
       mov       rcx,19980208B10
       cmp       rax,rcx
       jne       near ptr M05_L98
       mov       r12,[rsp+120]
       cmp       r12,r14
       jne       near ptr M05_L173
       mov       rcx,[rsp+0E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2AA578]; System.RuntimeType.GetGenericArguments()
M05_L39:
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L175
       mov       r12,[rax+10]
       mov       rcx,[rsp+0E8]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A526028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E0],rax
M05_L40:
       cmp       ebp,1
       jb        near ptr M05_L109
       add       rdi,2
       dec       ebp
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       mov       rdx,r12
       lea       r8,[rsp+128]
       lea       rcx,[rsp+290]
       call      qword ptr [7FFD1A775A70]
       mov       rdi,[rsp+298]
       mov       ebp,[rsp+2A0]
       mov       ecx,ebp
       test      ecx,ecx
       je        near ptr M05_L174
       test      ebp,ebp
       je        near ptr M05_L175
       movzx     eax,word ptr [rdi]
       cmp       eax,7B
       je        short M05_L44
       cmp       eax,7D
       jne       near ptr M05_L90
       jmp       near ptr M05_L93
M05_L41:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+2D4]
       jmp       near ptr M05_L73
M05_L42:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+2D4]
       jmp       near ptr M05_L73
M05_L43:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+2D4]
       jmp       near ptr M05_L73
M05_L44:
       mov       r8d,4
M05_L45:
       mov       [rsp+2AC],r8d
       mov       rcx,[rsp+0E0]
       mov       rdx,[rsp+290]
       mov       r11,7FFD1A220700
       call      qword ptr [r11]
       mov       ecx,[rsp+2AC]
       cmp       ecx,8
       je        near ptr M05_L40
       cmp       ecx,0B
       jne       short M05_L46
       cmp       ebp,1
       jb        near ptr M05_L109
       add       rdi,2
       dec       ebp
M05_L46:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+0E0]
       call      CORINFO_HELP_ASSIGN_REF
M05_L47:
       mov       eax,7
       mov       [rsp+0F8],r12
       mov       r12d,eax
       jmp       near ptr M05_L07
M05_L48:
       mov       edx,6
       jmp       near ptr M05_L10
M05_L49:
       cmp       dword ptr [rsp+2D4],5
       je        near ptr M05_L19
       mov       rax,[rsp+108]
M05_L50:
       mov       r8d,[rsp+2D4]
       cmp       r8d,4
       jne       near ptr M05_L32
       jmp       near ptr M05_L88
M05_L51:
       mov       edx,5
       jmp       near ptr M05_L10
M05_L52:
       mov       rbx,[rbx+20]
M05_L53:
       test      rbx,rbx
       je        near ptr M05_L103
       cmp       qword ptr [rbx+48],0
       jne       near ptr M05_L60
       jmp       short M05_L56
M05_L54:
       mov       edx,4
       jmp       near ptr M05_L10
M05_L55:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,199F5004E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A7780C0
       mov       [r13+18],rcx
       mov       rcx,199F5004E90
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L56:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD1A5578A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+88]
       jmp       near ptr M05_L60
M05_L57:
       mov       r13d,[rsp+250]
       test      r13d,r13d
       jl        near ptr M05_L114
       mov       r15,[rsp+240]
       test      r15,r15
       je        near ptr M05_L115
       cmp       [r15+8],r13d
       je        short M05_L59
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r13d,r8d
       cmovg     r13d,r8d
       mov       r8d,r13d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L71
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M05_L58:
       mov       [rsp+240],r12
M05_L59:
       mov       ecx,[rsp+250]
       mov       [rsp+254],ecx
       mov       r15,[rsp+240]
       jmp       near ptr M05_L02
M05_L60:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       je        short M05_L61
       mov       rcx,rbx
       call      qword ptr [7FFD1A5558F0]
M05_L61:
       test      byte ptr [rbx+5C],10
       jne       short M05_L64
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M05_L129
       mov       rcx,[rbx+38]
       cmp       [rcx],r14
       jne       near ptr M05_L130
M05_L62:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M05_L63:
       test      eax,eax
       je        near ptr M05_L104
M05_L64:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M05_L70
M05_L65:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M05_L105
       cmp       qword ptr [rbx+48],0
       je        short M05_L68
M05_L66:
       mov       rax,[rsp+88]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbx+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A5579C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L67:
       cmp       r8d,4
       jne       short M05_L73
       jmp       short M05_L69
M05_L68:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD1A5578A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L66
M05_L69:
       mov       rbx,[rsp+110]
       test      rbx,rbx
       mov       [rsp+110],rbx
       jne       short M05_L73
       jmp       short M05_L72
M05_L70:
       mov       rcx,rbx
       call      qword ptr [7FFD1A555920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M05_L65
M05_L71:
       call      qword ptr [7FFD1A415BD8]
       jmp       near ptr M05_L58
M05_L72:
       mov       rdx,[rsp+0F0]
       mov       rbx,rdx
       mov       [rsp+110],rbx
M05_L73:
       cmp       r8d,3
       je        short M05_L74
       mov       r12d,r8d
M05_L74:
       mov       r11d,[rsp+2D0]
       cmp       r11d,ebp
       ja        near ptr M05_L109
       mov       r8d,r11d
       lea       rdi,[rdi+r8*2]
       sub       ebp,r11d
       mov       [rsp+108],rax
       jmp       near ptr M05_L07
M05_L75:
       cmp       ecx,3
       je        near ptr M05_L123
       jmp       near ptr M05_L14
M05_L76:
       test      rcx,rcx
       je        near ptr M05_L118
       cmp       [rcx],r14
       jne       near ptr M05_L118
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2B6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M05_L119
       jmp       near ptr M05_L06
M05_L77:
       cmp       ecx,7
       jne       near ptr M05_L122
       test      r8d,r8d
       je        near ptr M05_L175
       movzx     ecx,word ptr [r11]
       cmp       ecx,22
       jne       near ptr M05_L121
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1F8],xmm0
       cmp       r8d,1
       jb        near ptr M05_L109
       add       r11,2
       sub       r8d,1
       mov       [rsp+40],r11
       mov       [rsp+13C],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD1A5F6148]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+20C],eax
       cmp       eax,[rsp+13C]
       ja        near ptr M05_L109
       mov       rcx,[rsp+40]
       mov       [rsp+1F8],rcx
       mov       [rsp+200],eax
       lea       rcx,[rsp+1F8]
       call      qword ptr [7FFD1A41C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+38],rax
       mov       edx,[rsp+20C]
       add       edx,2
       mov       [rsp+138],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+138]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       jmp       near ptr M05_L12
M05_L78:
       cmp       r8d,9
       jne       short M05_L79
       mov       rdx,[rsp+0F0]
       mov       r10,rdx
       mov       [rsp+100],r10
       jmp       near ptr M05_L73
M05_L79:
       cmp       r8d,7
       jne       near ptr M05_L67
       mov       rdx,[rsp+0F0]
       mov       r9,rdx
       mov       [rsp+0F8],r9
       jmp       near ptr M05_L73
M05_L80:
       mov       rcx,offset MT_System.String
       mov       rdx,[rsp+88]
       cmp       [rdx],rcx
       jne       near ptr M05_L87
       mov       rcx,rdx
M05_L81:
       test      rcx,rcx
       je        short M05_L82
       mov       rdx,19980208B38
       xor       r8d,r8d
       call      qword ptr [7FFD1A3662F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       mov       rdx,[rsp+88]
       jne       near ptr M05_L127
M05_L82:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M05_L131
       cmp       qword ptr [rbx+20],0
       je        near ptr M05_L128
       jmp       near ptr M05_L52
M05_L83:
       xor       ebx,ebx
       mov       [rsp+0F8],r9
       mov       [rsp+100],r10
       jmp       near ptr M05_L20
M05_L84:
       mov       rdx,[rsp+0F0]
       mov       [rsp+108],rdx
       mov       rax,[rsp+108]
       jmp       near ptr M05_L73
M05_L85:
       mov       r11d,[rsp+2D0]
       cmp       r11d,ebp
       ja        near ptr M05_L109
       mov       ecx,r11d
       lea       rdi,[rdi+rcx*2]
       sub       ebp,r11d
       jmp       short M05_L89
M05_L86:
       cmp       [r10],r14
       jne       near ptr M05_L125
       mov       rcx,r10
       call      qword ptr [7FFD1A2B7330]; System.RuntimeType.GetBaseType()
       mov       rcx,199802021B8
       cmp       rax,rcx
       jne       near ptr M05_L126
       jmp       near ptr M05_L80
M05_L87:
       mov       rcx,rdx
       mov       r8,[rdx]
       mov       r8,[r8+40]
       call      qword ptr [r8+8]
       mov       rcx,rax
       mov       rdx,[rsp+88]
       jmp       near ptr M05_L81
M05_L88:
       cmp       r12d,9
       je        near ptr M05_L164
       jmp       near ptr M05_L32
M05_L89:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,2D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L90:
       cmp       eax,22
       jne       short M05_L91
       mov       r8d,6
       jmp       near ptr M05_L45
M05_L91:
       cmp       eax,3A
       jne       short M05_L92
       mov       r8d,9
       jmp       near ptr M05_L45
M05_L92:
       cmp       eax,2C
       jne       short M05_L94
       mov       r8d,8
       jmp       near ptr M05_L45
M05_L93:
       mov       eax,5
       mov       r8d,eax
       jmp       near ptr M05_L45
M05_L94:
       cmp       eax,5B
       jne       short M05_L95
       mov       r8d,0A
       jmp       near ptr M05_L45
M05_L95:
       cmp       eax,5D
       jne       short M05_L96
       mov       r8d,0B
       jmp       near ptr M05_L45
M05_L96:
       cmp       eax,20
       jne       short M05_L97
       mov       ecx,3
       mov       r8d,ecx
       jmp       near ptr M05_L45
M05_L97:
       xor       ecx,ecx
       mov       r8d,ecx
       jmp       near ptr M05_L45
M05_L98:
       mov       rcx,[rsp+0E8]
       mov       [rsp+0E8],rcx
       mov       rax,[rcx]
       mov       [rsp+120],rax
       mov       rdx,[rax+58]
       call      qword ptr [rdx+10]
       test      eax,eax
       je        near ptr M05_L101
       mov       rcx,[rsp+0E8]
       mov       r12,[rsp+120]
       mov       rax,[r12+68]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0D0],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+0D0]
       mov       rcx,19980208B10
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2AA758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A526028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0D8],rax
M05_L99:
       cmp       ebp,1
       jb        near ptr M05_L109
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+128],rdx
       mov       [rsp+130],r8d
       mov       rdx,r12
       lea       r8,[rsp+128]
       lea       rcx,[rsp+270]
       call      qword ptr [7FFD1A775A70]
       mov       rdi,[rsp+278]
       mov       ebp,[rsp+280]
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       lea       rdx,[rsp+128]
       mov       ecx,1
       call      qword ptr [7FFD1A775B30]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+28C],eax
       mov       rcx,[rsp+0D8]
       mov       rdx,[rsp+270]
       mov       r11,7FFD1A2206E8
       call      qword ptr [r11]
       mov       ecx,[rsp+28C]
       cmp       ecx,8
       je        near ptr M05_L99
       mov       rax,[rsp+0D8]
       cmp       ecx,0B
       jne       short M05_L100
       cmp       ebp,1
       jb        near ptr M05_L109
       add       rdi,2
       dec       ebp
M05_L100:
       mov       rcx,rax
       mov       r11,7FFD1A2206F0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFD1A2B7678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r12,rax
       mov       rcx,[rsp+0D8]
       mov       rdx,r12
       mov       r11,7FFD1A2206F8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       rcx,rax
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A77C000]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0C8]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+0C8]
       jmp       near ptr M05_L47
M05_L101:
       mov       rcx,[rsp+0E8]
       mov       rax,[rsp+120]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rax,[rsp+108]
       mov       r8d,[rsp+2D4]
       jmp       near ptr M05_L73
M05_L102:
       mov       rcx,r15
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L103:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A77F7F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A36F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L104:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD1A87C198]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD1A636340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L105:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD1A77F618]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD1A6362B0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L106:
       mov       rcx,r8
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L107:
       mov       rcx,rdx
       mov       rdx,[rsp+0C0]
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L108:
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L109:
       call      qword ptr [7FFD1A4FE9D0]
       int       3
M05_L110:
       mov       rcx,199F5001F30
       mov       r15,[rcx]
       jmp       near ptr M05_L02
M05_L111:
       mov       rax,[rsp+108]
       mov       r10,[rsp+100]
       mov       r15,[rsp+118]
       cmp       ecx,20
       jne       short M05_L112
       mov       edx,3
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M05_L10
M05_L112:
       cmp       r12d,9
       je        short M05_L113
       xor       edx,edx
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M05_L10
M05_L113:
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M05_L08
M05_L114:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD1A4FED48]
       int       3
M05_L115:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+240],rax
       jmp       near ptr M05_L59
M05_L116:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M05_L02
M05_L117:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M05_L76
M05_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD1A77F2E8]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD1A214000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD1A36F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L119:
       mov       [rsp+260],rdi
       mov       [rsp+268],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+258]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+268]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,2D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L120:
       mov       rax,[rsp+108]
       mov       r10,[rsp+100]
       mov       r15,[rsp+118]
       mov       edx,2
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M05_L10
M05_L121:
       mov       r15,[rsp+118]
       mov       [rsp+128],r11
       mov       [rsp+130],r8d
       lea       rdx,[rsp+128]
       lea       rcx,[rsp+228]
       call      qword ptr [7FFD1A775B00]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       edx,7
       mov       r8d,[rsp+230]
       call      qword ptr [7FFD1A77C000]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+228]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       jmp       near ptr M05_L12
M05_L122:
       mov       r15,[rsp+118]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+23C]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M05_L12
M05_L123:
       mov       r15,[rsp+118]
       mov       [rsp+128],r11
       mov       [rsp+130],r8d
       lea       rcx,[rsp+128]
       call      qword ptr [7FFD1A775AB8]
       mov       [rsp+238],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rsp+0A8],r8
       mov       rcx,r8
       mov       edx,3
       mov       r8d,[rsp+238]
       call      qword ptr [7FFD1A77C000]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r8,[rsp+0A8]
       mov       rcx,r8
       mov       r8,rcx
       jmp       near ptr M05_L15
M05_L124:
       mov       rcx,rbx
       mov       r9,[rbx]
       mov       r9,[r9+50]
       call      qword ptr [r9+10]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M05_L23
M05_L125:
       mov       rcx,r10
       mov       r9,[r10]
       mov       r9,[r9+98]
       call      qword ptr [r9+20]
       mov       rcx,199802021B8
       cmp       rax,rcx
       je        near ptr M05_L80
M05_L126:
       mov       rcx,[rsp+78]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M05_L80
       mov       r10,[rsp+78]
       mov       rdx,[rsp+88]
       mov       rcx,rdx
       test      rcx,rcx
       je        near ptr M05_L133
       jmp       short M05_L132
M05_L127:
       mov       rcx,rbx
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L128:
       xor       ebx,ebx
       jmp       near ptr M05_L53
M05_L129:
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M05_L62
M05_L130:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M05_L63
M05_L131:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,[rsp+88]
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L132:
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M05_L106
M05_L133:
       mov       r9,19980204FE8
       cmp       r10,r9
       jne       short M05_L135
       lea       r9,[rsp+180]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2BDC98]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L134
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+180]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L134:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L135:
       mov       r9,19980208938
       cmp       r10,r9
       jne       short M05_L137
       lea       r9,[rsp+188]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A3148B8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L136
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+188]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L136:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L137:
       mov       r9,19980208A28
       cmp       r10,r9
       jne       short M05_L139
       lea       r9,[rsp+194]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFD1A31C840]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L138
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       vmovss    xmm0,dword ptr [rsp+194]
       vmovss    dword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L138:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L139:
       mov       r9,19980205740
       cmp       r10,r9
       jne       short M05_L141
       lea       r9,[rsp+198]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFD1A34C648]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L140
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       vmovsd    xmm0,qword ptr [rsp+198]
       vmovsd    qword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L140:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L141:
       mov       rdx,19980203C58
       cmp       r10,rdx
       jne       near ptr M05_L145
       test      rcx,rcx
       jne       short M05_L142
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M05_L143
M05_L142:
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
M05_L143:
       mov       [rsp+128],rdx
       mov       [rsp+130],r8d
       lea       rcx,[rsp+128]
       lea       rdx,[rsp+1A0]
       call      qword ptr [7FFD1A2BCA98]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L144
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1A0]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L144:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L145:
       mov       r9,19980208988
       cmp       r10,r9
       jne       short M05_L147
       lea       r9,[rsp+1A8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2FD2D8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L146
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1A8]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L146:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L147:
       mov       r9,199802089B0
       cmp       r10,r9
       jne       short M05_L149
       lea       r9,[rsp+1B0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2FC2B8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L148
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1B0]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L148:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L149:
       mov       rdx,19980208848
       cmp       r10,rdx
       jne       short M05_L151
       lea       rdx,[rsp+1B8]
       call      qword ptr [7FFD1A2F5B60]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L150
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1B8]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L150:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L151:
       mov       r9,199802089D8
       cmp       r10,r9
       jne       short M05_L153
       lea       r9,[rsp+1C0]
       mov       edx,6F
       xor       r8d,r8d
       call      qword ptr [7FFD1A484558]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L152
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       vmovups   xmm0,[rsp+1C0]
       vmovups   [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L152:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L153:
       mov       r9,19980205F80
       cmp       r10,r9
       jne       short M05_L155
       lea       r9,[rsp+1D0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A3159C8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L154
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1D0]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L154:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L155:
       mov       r9,19980208960
       cmp       r10,r9
       jne       short M05_L157
       lea       r9,[rsp+1D8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A316AF0]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L156
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1D8]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L156:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L157:
       mov       r9,19980208910
       cmp       r10,r9
       jne       short M05_L159
       lea       r9,[rsp+1E0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2FE580]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L158
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1E0]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L158:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L159:
       mov       r9,19980208610
       cmp       r10,r9
       jne       short M05_L161
       lea       r9,[rsp+1E8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2FF6A8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        short M05_L160
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1E8]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L160:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L161:
       mov       rdx,19980208A68
       cmp       r10,rdx
       mov       [rsp+80],rbx
       jne       short M05_L163
       lea       rdx,[rsp+1F0]
       call      qword ptr [7FFD1A654420]
       test      eax,eax
       je        short M05_L162
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1F0]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L162:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L163:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L50
M05_L164:
       mov       r10,[rsp+100]
       mov       r15,[rsp+118]
       mov       [rsp+108],rax
       mov       rcx,rax
       mov       [rsp+100],r10
       mov       rdx,r10
       call      qword ptr [7FFD1A775A40]; Ferris.Json.JsonTransformer.AreTokensSetupForPropertyValue(Ferris.Json.TokenInfo, Ferris.Json.TokenInfo)
       test      eax,eax
       mov       rax,[rsp+108]
       mov       r8d,[rsp+2D4]
       je        near ptr M05_L168
       mov       [rsp+108],rax
       mov       rdx,[rax+8]
       mov       [rsp+0C0],rdx
       mov       rcx,rdx
       mov       [rsp+0B8],rcx
       test      rcx,rcx
       je        near ptr M05_L167
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       jne       near ptr M05_L107
M05_L165:
       lea       r8,[rsp+2C8]
       mov       rcx,r15
       mov       rdx,[rsp+0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A3F4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+2D4]
       je        near ptr M05_L166
       mov       rcx,[rsp+2C8]
       mov       rdx,[rsp+2C8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       lea       r8,[rsp+128]
       lea       rcx,[rsp+2B0]
       call      qword ptr [7FFD1A775A70]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+2B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,7
       mov       rdi,[rsp+2B8]
       mov       ecx,[rsp+2C0]
       mov       eax,ecx
       mov       [rsp+0F8],r12
       mov       r12d,ebp
       mov       ebp,eax
       jmp       near ptr M05_L07
M05_L166:
       mov       rax,[rsp+108]
       jmp       near ptr M05_L73
M05_L167:
       jmp       near ptr M05_L165
M05_L168:
       jmp       near ptr M05_L73
M05_L169:
       xor       ecx,ecx
       mov       [rsp+100],rax
       jmp       near ptr M05_L35
M05_L170:
       mov       rdx,[rcx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
M05_L171:
       mov       rcx,rax
       mov       [rsp+0E8],rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       jmp       near ptr M05_L37
M05_L172:
       mov       [rsp+0E8],rdx
       mov       rcx,rdx
       mov       r8,[rsp+120]
       mov       rax,[r8+68]
       call      qword ptr [rax+18]
       jmp       near ptr M05_L38
M05_L173:
       mov       rcx,[rsp+0E8]
       mov       rax,[r12+68]
       call      qword ptr [rax+28]
       jmp       near ptr M05_L39
M05_L174:
       mov       ecx,2
       mov       r8d,ecx
       jmp       near ptr M05_L45
M05_L175:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 7979
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD79CF41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD79D07B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD79D08B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftListMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,212CFC041A8
       mov       rdi,[rsi]
       mov       rcx,212CFC04E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L04
       xor       ebp,ebp
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A776D48]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbp,rbp
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFD1A774420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,212802090D0
       xor       r8d,r8d
       call      qword ptr [7FFD1A774510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       r8,rax
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.MixedListTestObj
       cmp       [r8],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L02:
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rax,[r8+8]
       cmp       ecx,[rax+10]
       jne       short M00_L03
       inc       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       dec       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FFD1A776DC0]
       jmp       near ptr M00_L01
; Total bytes of code 236
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,212CFC04ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,212CFC050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,212CFC04ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,212CFC050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,212CFC00428
       mov       r13,[rcx]
       mov       rcx,212CFC014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21280201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,212CFC05078
       mov       rax,212CFC05080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A74A608
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A40D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD1A59A130]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD1A77F540]
M02_L07:
       mov       rcx,[r14+8]
       test      rcx,rcx
       jne       short M02_L08
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       mov       eax,[rcx+10]
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       eax
M02_L10:
       test      eax,eax
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD1A211218
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 768
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,212CFC04E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD1A776D48]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD1A781560]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A74A608
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A516640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD1A776DC0]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD1A776DC0]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD1A2112E8
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD1A2112F0
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD79D0B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.TextJsonListMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,232320041A8
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,23232004F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L12
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L13
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L14
       mov       rdx,[rdi+0B8]
       mov       r8,232002087E0
       cmp       rdx,r8
       jne       near ptr M00_L14
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L07
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.MixedListTestObj ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.MixedListTestObj>)
       call      qword ptr [7FFD1A776EC8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L08
       mov       rdx,23232004F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L09
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L10
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L15
       mov       rdx,[r15+0B8]
       mov       r8,232002087E0
       cmp       rdx,r8
       jne       near ptr M00_L15
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L16
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.MixedListTestObj>)
       call      qword ptr [7FFD1A954C60]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,232320041A8
       mov       rcx,[rcx]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+10]
       jne       short M00_L11
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L08:
       mov       ecx,389E
       mov       rdx,7FFD1A74A610
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A77C018]
       int       3
M00_L09:
       mov       rcx,23232004F48
       xor       edx,edx
       call      qword ptr [7FFD1A7759B0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFD1A775908]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L11:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,23232004F48
       xor       edx,edx
       call      qword ptr [7FFD1A7759B0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFD1A775908]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L14:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,232002087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7751B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,232002087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7751B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 659
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A775980]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L12
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L13
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L16
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,23232001FF8
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD1A924758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L04
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
M01_L01:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L15
       mov       rdi,23200201C08
M01_L02:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L03:
       mov       [rbp-88],r14
       jmp       short M01_L05
M01_L04:
       mov       edx,2
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD1A776C88]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L09
       cmp       [rcx+8],r15d
       jb        short M01_L08
M01_L06:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L11
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L10
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L07:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M01_L08
       mov       r12d,r15d
       jmp       short M01_L11
M01_L08:
       call      qword ptr [7FFD1A4EE9D0]
       int       3
M01_L09:
       test      r15d,r15d
       jne       short M01_L08
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L06
M01_L10:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L07
M01_L11:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD1A77D908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L17
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L13:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A91F078]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD1A91C5E8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L03
M01_L15:
       mov       rcx,7FFD1A74C120
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23232004F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L02
M01_L16:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD1A91EB80]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD1A91C768]
       mov       r14,r13
       jmp       near ptr M01_L03
M01_L17:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L18
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L19
M01_L18:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L20
M01_L19:
       mov       rax,[rcx]
       add       rax,10
M01_L20:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L21
       test      r10d,r10d
       jne       short M01_L22
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L24
M01_L21:
       cmp       [rcx+8],r10d
       jae       short M01_L23
M01_L22:
       call      qword ptr [7FFD1A4EE9D0]
       int       3
M01_L23:
       add       rcx,10
M01_L24:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L26
       cmp       rdx,300
       ja        short M01_L25
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L26
M01_L25:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD1A405BA8]
M01_L26:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,23232001FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD1A924760]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1186
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,6EBC9844AD4B
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+28],rcx
       cmp       edi,55
       jle       near ptr M02_L11
       cmp       edi,15555555
       ja        short M02_L04
       mov       rdx,23232001FF8
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFD1A924758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
M02_L01:
       test      rax,rax
       je        near ptr M02_L12
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M02_L02:
       mov       rax,r15
M02_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       jmp       short M02_L05
M02_L04:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFD1A77D950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L01
M02_L05:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFD1A77D968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        short M02_L08
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L07
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L06
       jmp       short M02_L09
M02_L06:
       mov       ecx,347F
       mov       rdx,7FFD1A74A610
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A77C078]
       int       3
M02_L07:
       mov       ecx,347F
       mov       rdx,7FFD1A74A610
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A77C0C0]
       int       3
M02_L08:
       call      qword ptr [7FFD1A4EE9D0]
       int       3
M02_L09:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFD1A955AD0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD1A956B80]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A815938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rcx,[rbp+78]
       xor       edx,edx
       mov       [rbp+78],rdx
       mov       [rbp+20],rcx
       mov       rcx,[rbp]
       call      M02_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,6EBC9844AD4B
       cmp       [rbp+8],rcx
       je        short M02_L10
       call      CORINFO_HELP_FAIL_FAST
M02_L10:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M02_L03
M02_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M02_L02
M02_L13:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M02_L37
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M02_L15
       cmp       rdx,300
       ja        short M02_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFD1A405BA8]
M02_L15:
       mov       rcx,23232001FF8
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFD1A295120
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L16
       mov       rcx,r14
       call      qword ptr [7FFD1A91F108]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M02_L32
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M02_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFD1A7AD2D8]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A204000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFD1A35F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       r15,[rcx+rdx+10]
       mov       rsi,[r15]
       mov       rdx,[rbp+28]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],eax
       test      rsi,rsi
       je        near ptr M02_L32
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M02_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFD1A91F090]
M02_L18:
       mov       rbx,[rax+8]
       mov       rcx,7FFD1A295120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A295C38],0
       je        short M02_L20
       call      qword ptr [7FFD1A35DC98]
       mov       edi,eax
       jmp       short M02_L23
M02_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L20:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M02_L21
       call      qword ptr [7FFD1A9D5398]
       jmp       short M02_L22
M02_L21:
       mov       eax,edi
       sar       eax,10
M02_L22:
       mov       edi,eax
M02_L23:
       mov       rcx,7FFD1A295120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFD1A295C2C]
       mov       edi,edx
       xor       r15d,r15d
       jmp       near ptr M02_L30
M02_L24:
       cmp       edi,[rbx+8]
       jae       short M02_L19
       mov       ecx,edi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L26
       test      r10d,r10d
       jne       short M02_L27
       xor       edx,edx
       mov       [rax+14],edx
M02_L25:
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M02_L26:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M02_L28
       mov       ecx,1
       jmp       short M02_L31
M02_L27:
       jmp       short M02_L25
M02_L28:
       inc       edi
       cmp       [rbx+8],edi
       jne       short M02_L29
       xor       edi,edi
M02_L29:
       inc       r15d
M02_L30:
       cmp       [rbx+8],r15d
       jg        near ptr M02_L24
       xor       ecx,ecx
M02_L31:
       mov       ebx,ecx
M02_L32:
       mov       rax,232320005D0
       mov       r15,[rax]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,esi
       mov       r9d,edi
       mov       edx,3
       call      qword ptr [7FFD1A407678]
       test      ebx,r12d
       jne       short M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       esi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M02_L33
       mov       ecx,0FFFFFFFF
       jmp       short M02_L34
M02_L33:
       mov       ecx,r13d
M02_L34:
       mov       edx,ebx
       mov       r8d,esi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L35
       mov       eax,1
       jmp       short M02_L36
M02_L35:
       xor       eax,eax
M02_L36:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD1A51E2B0]
M02_L37:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1600
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M03_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M03_L03
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       jmp       qword ptr [7FFD1A3543A8]
M03_L03:
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       jne       short M03_L00
       jmp       short M03_L02
; Total bytes of code 71
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD1A775338]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD1A774390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD1A7775E8]
       mov       [rbp-40],rax
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFD1A7774E0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M04_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A775398]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD1A777570]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M04_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M04_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M05_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD1A774390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M05_L05
       call      qword ptr [7FFD1A7774E0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD1A354360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M05_L03
       jmp       near ptr M05_L09
M05_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L03:
       call      qword ptr [7FFD1A7776F0]
       test      eax,eax
       je        near ptr M05_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD1A814450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD1A814450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD1A814480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD1A7775B8]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M05_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A814318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A814318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A814318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A775908]
       jmp       short M05_L09
M05_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A814390]
       jmp       short M05_L09
M05_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD1A354360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L07
M05_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M05_L08
M05_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M05_L08:
       cmp       dword ptr [rbp-34],0
       je        short M05_L09
       call      qword ptr [7FFD1A77C978]
M05_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A7758C0]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M06_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A775170]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A814360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       cmp       qword ptr [rbp-8],0
       je        short M06_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD1A776598]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M06_L01
M06_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD1A775920]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M06_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M06_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD1A614720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M06_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A775380]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD1A77CF60]
M06_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisSingleMapping()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,22FD5C04198
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD1A2966D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L08
       cmp       dword ptr [rsp+68],1
       jne       near ptr M00_L09
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
M00_L00:
       mov       rdx,rsi
       call      qword ptr [7FFD1A72FB40]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       short M00_L01
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L02
M00_L01:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L02:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,22F802087E0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD1A72FC00]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M00_L10
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L04
       mov       r8,22FD5C00438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L04
       mov       r8,22FD5C00418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L11
M00_L04:
       mov       rcx,[rsp+40]
       mov       rdx,22F802087E0
       call      qword ptr [7FFD1A754450]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       r8,rax
       test      r8,r8
       je        short M00_L05
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [r8],rcx
       je        short M00_L05
       mov       rdx,rax
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L05:
       mov       rdx,22FD5C04198
       mov       rdx,[rdx]
       mov       rcx,[rdx+8]
       mov       rdx,[r8+8]
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L07
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A3F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L07
M00_L06:
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rdx,22FD5C01F30
       mov       rcx,[rdx]
       jmp       near ptr M00_L00
M00_L09:
       lea       rdx,[rsp+58]
       mov       r8d,[rsp+68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD1A50FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rcx,[rsp+58]
       jmp       near ptr M00_L00
M00_L10:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD1A484030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L04
; Total bytes of code 556
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L03
       test      dil,1
       je        short M01_L00
       mov       rdx,rbx
       mov       rcx,22FD5C00590
       mov       rcx,[rcx]
       call      qword ptr [7FFD1A946EB0]
       mov       rbx,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rbx+8]
       mov       eax,ecx
       cmp       word ptr [rbx+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rbx
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L22
       test      r15d,r15d
       je        near ptr M01_L09
       cmp       ecx,r15d
       je        near ptr M01_L08
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,r15d
       cmp       [rbx],bl
       lea       rcx,[rbx+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFD1A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L10
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L10
       mov       rbp,rax
M01_L05:
       mov       [rsp+38],rbx
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       jne       short M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
M01_L06:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        short M01_L11
       cmp       r12d,2
       je        short M01_L13
       jmp       near ptr M01_L15
M01_L07:
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       mov       rbx,r12
       jmp       near ptr M01_L02
M01_L09:
       mov       rbx,22F80200008
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rbp
       call      qword ptr [7FFD1A296658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L05
M01_L11:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A535050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L12
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD1A536838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L12:
       mov       r12,rax
       jmp       short M01_L17
M01_L13:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A535050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L14
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD1A536838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L14:
       jmp       short M01_L17
M01_L15:
       cmp       byte ptr [rbp+18],0
       je        short M01_L16
       mov       r12,[rbp+8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD1A536838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L17:
       xor       edi,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L21
M01_L18:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,edi
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M01_L20
       test      r15d,r15d
       jne       short M01_L23
       test      r14,r14
       jne       near ptr M01_L24
M01_L19:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD1A534FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L20:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L18
M01_L21:
       mov       rdx,[rsp+50]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rsi+10],eax
       mov       eax,[rsp+64]
       mov       [rsi+14],eax
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFD1A347258]
       int       3
M01_L23:
       mov       rcx,r10
       mov       rdx,rbx
       mov       r8d,r13d
       call      qword ptr [7FFD1A296538]
       test      eax,eax
       je        short M01_L20
       mov       r10,[rsp+40]
       test      r14,r14
       je        near ptr M01_L19
M01_L24:
       mov       rcx,r10
       call      qword ptr [7FFD1A5ED8F0]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L20
       mov       r10,[rsp+40]
       jmp       near ptr M01_L19
; Total bytes of code 826
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       vzeroupper
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-1A0],rsp
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L86
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       [rbp-140],rdi
       mov       [rbp-148],rsi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,[rbp-3C]
       mov       rcx,[rsi+rcx*8+10]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-150]
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rdx
       jne       near ptr M02_L89
       mov       rcx,[rbp-150]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L87
       test      rcx,rcx
       je        near ptr M02_L88
M02_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD1A523280]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r14,rax
M02_L05:
       mov       rcx,[rbp-150]
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M02_L83
       mov       r15,[rbp-150]
       mov       rcx,[rbp-150]
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L32
M02_L06:
       mov       rcx,[r15+38]
       mov       r15,[rcx+18]
M02_L07:
       test      r14,r14
       je        near ptr M02_L30
       mov       rcx,22F80200020
       cmp       r15,rcx
       jne       near ptr M02_L90
M02_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,22FD5C01EE8
       mov       r13,[rcx]
       mov       rcx,r13
       mov       edx,100
       call      qword ptr [7FFD1A519EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M02_L91
       lea       r12,[rax+10]
       mov       eax,[rax+8]
M02_L09:
       mov       [rbp-50],r12
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L92
       mov       rdx,22F80208814
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-58]
       inc       edx
       mov       [rbp-58],edx
M02_L10:
       mov       rdx,[rbp-150]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdx],rcx
       jne       near ptr M02_L98
       mov       r15,[rbp-150]
       mov       rdx,[rbp-150]
       mov       r12,[rdx+8]
       test      r12,r12
       je        near ptr M02_L28
M02_L11:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L99
M02_L12:
       test      r12,r12
       je        near ptr M02_L99
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M02_L99
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD1A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-58]
       add       edx,[r12+8]
       mov       [rbp-58],edx
M02_L13:
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L100
       mov       rdx,22F8020887C
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-58]
       add       edx,3
       mov       [rbp-58],edx
M02_L14:
       mov       [rbp-0D0],r14
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L27
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A344348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L26
       xor       r8d,r8d
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D0]
       cmp       qword ptr [rbp-0D8],0
       jne       short M02_L15
       mov       r8,[r8]
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D8]
       cmp       qword ptr [rbp-0D8],0
       je        near ptr M02_L93
M02_L15:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L94
M02_L16:
       mov       r15,rcx
M02_L17:
       test      r15,r15
       je        short M02_L18
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L95
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD1A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-58]
       add       ecx,[r15+8]
       mov       [rbp-58],ecx
M02_L18:
       xor       ecx,ecx
       mov       [rbp-0D8],rcx
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L103
       mov       rcx,22F80208814
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M02_L19:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rax,[rbp-50]
       mov       [rbp-138],rax
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r15,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r15,r15
       je        near ptr M02_L22
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFD1A285120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L96
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-0E8],1
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       short M02_L21
       mov       dword ptr [rbp-0E4],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r15+8],edx
       jne       near ptr M02_L97
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-178],r10
       mov       r9,[r10]
       mov       [rbp-180],r9
       mov       rcx,r10
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-178]
       mov       [rdx+8],ecx
       mov       rax,[rbp-180]
       test      rax,rax
       mov       [rbp-180],rax
       mov       eax,[rbp-0E4]
       jne       near ptr M02_L104
M02_L21:
       mov       rcx,22FD5C005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L118
M02_L22:
       mov       rdx,r12
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L29
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       mov       edx,[rbp-3C]
       inc       edx
       mov       [rbp-3C],edx
       mov       edx,[rsi+8]
       cmp       edx,[rbp-3C]
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,22F80200C60
       call      qword ptr [7FFD1A346DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M02_L84
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L84
       mov       ecx,[rbx+8]
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L85
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,22F80208A9C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFD1A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbx+8]
       inc       eax
       cdqe
       lea       rax,[r14+rax*2+0C]
       mov       rcx,22F80208AB4
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       rax,r14
M02_L25:
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L26:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A344348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L102
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A3443C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-68]
       mov       r11,7FFD1A200710
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L17
M02_L27:
       lea       rcx,[rbp-68]
       mov       r8,[rbp-0D0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD1A967798]
       jmp       near ptr M02_L18
M02_L28:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0B8],xmm0
       mov       rdx,[r15+48]
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFD1A536B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0B8]
       vmovups   [rbp-0C8],xmm0
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFD1A536BE0]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L11
M02_L29:
       mov       rcx,rdi
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L30:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,22F80208808
       mov       r8,22F80208820
       call      qword ptr [7FFD1A346B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L31
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L31:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L32:
       mov       rcx,[r15+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r13,rax
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       [rbp-88],r13
       mov       [rbp-80],rax
       lea       rdx,[rbp-0A8]
       mov       [rsp+20],rdx
       mov       edx,[r15+50]
       lea       rcx,[rbp-88]
       lea       r8,[rbp-90]
       lea       r9,[rbp-98]
       call      qword ptr [7FFD1A5957E8]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       r13,[rbp-0A0]
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r9,[r15+30]
       mov       rcx,r12
       mov       rdx,r13
       mov       r8d,[rbp-0A8]
       call      qword ptr [7FFD1A537B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r15+38]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L33:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A3FDF98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-158],r14
       mov       rcx,[rbp-150]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD1A344348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L42
       mov       rcx,rax
       mov       r11,7FFD1A2006F0
       call      qword ptr [r11]
       mov       [rbp-160],rax
       jmp       near ptr M02_L41
M02_L34:
       mov       rcx,[rbp-160]
       mov       r11,7FFD1A200700
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,22F80200020
       cmp       rax,rcx
       je        short M02_L35
       mov       rcx,22F80208848
       cmp       rax,rcx
       jne       near ptr M02_L37
M02_L35:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,22F80208808
       mov       r8,22F80208808
       call      qword ptr [7FFD1A346B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L36
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L41
M02_L36:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L41
M02_L37:
       mov       rcx,rax
       call      qword ptr [7FFD1A297330]; System.RuntimeType.GetBaseType()
       mov       rcx,22F802021B8
       cmp       rax,rcx
       jne       short M02_L39
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,rax
       mov       edx,1C
       call      qword ptr [7FFD1A28A6C8]; System.RuntimeType.GetProperties(System.Reflection.BindingFlags)
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD1A72FB40]
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L38
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L41
M02_L38:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L41
M02_L39:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L40
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L41
M02_L40:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L41:
       mov       rcx,[rbp-160]
       mov       r11,7FFD1A2006F8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L34
       mov       rcx,rsp
       call      M02_L124
       nop
M02_L42:
       mov       rdx,[rbp-158]
       mov       rcx,22F80200C60
       call      qword ptr [7FFD1A346DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       r14,rbx
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-148]
       mov       rdi,[rbp-140]
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L43
       mov       rcx,22F80208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L44
M02_L43:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L44:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L45
       mov       rcx,22F802088C4
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L46
M02_L45:
       lea       rcx,[rbp-68]
       mov       rdx,22F802088B8
       call      qword ptr [7FFD1A4658F0]
M02_L46:
       lea       rcx,[rbp-68]
       mov       rdx,r14
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L47
       mov       rcx,22F802088E4
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L48
M02_L47:
       lea       rcx,[rbp-68]
       mov       rdx,22F802088D8
       call      qword ptr [7FFD1A4658F0]
M02_L48:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L49
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L49:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L50:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       mov       rcx,22F802021B8
       cmp       rax,rcx
       jne       near ptr M02_L52
       mov       rcx,r15
       mov       edx,1C
       mov       rax,[r15]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L52
       mov       rcx,r15
       mov       edx,1C
       mov       rax,[r15]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD1A72FB40]
       mov       r15,rax
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r15
       mov       rcx,22F80208808
       mov       r8,22F802088F0
       call      qword ptr [7FFD1A346B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L51
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L51:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L52:
       mov       rcx,22F80208910
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,22F80208610
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,22F80204FE8
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,22F80208938
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F80205F80
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F80208960
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F80208988
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F802089B0
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F802089D8
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F80204BB0
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,22F80208A00
       cmp       r15,rcx
       jne       near ptr M02_L59
M02_L53:
       lea       rcx,[rbp-68]
       mov       edx,3
       mov       r8d,2
       call      qword ptr [7FFD1A4656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L54
       mov       rcx,22F80208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L55
M02_L54:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L55:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,2
       jb        short M02_L56
       mov       rcx,22F802088FC
       mov       eax,[rcx]
       mov       [rdx],eax
       mov       ecx,[rbp-58]
       add       ecx,2
       mov       [rbp-58],ecx
       jmp       short M02_L57
M02_L56:
       lea       rcx,[rbp-68]
       mov       rdx,22F802088F0
       call      qword ptr [7FFD1A4658F0]
M02_L57:
       lea       rcx,[rbp-68]
       mov       r8,r14
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5C6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L58
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L58:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L59:
       mov       rdx,22F80208A28
       cmp       r15,rdx
       jne       near ptr M02_L61
       mov       rdx,r14
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD1A344408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm0,dword ptr [rax]
       vmovss    dword ptr [rbp-6C],xmm0
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,22FD5C00428
       mov       rcx,[rcx]
       vmovss    xmm0,dword ptr [rbp-6C]
       vmovss    dword ptr [rbp-110],xmm0
       call      qword ptr [7FFD1A46F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovss    xmm0,dword ptr [rbp-110]
       mov       rdx,22F80208A50
       call      qword ptr [7FFD1A48FA98]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,22F80208808
       mov       r8,22F802088F0
       call      qword ptr [7FFD1A346B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L60
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L60:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L61:
       mov       rdx,22F80205740
       cmp       r15,rdx
       jne       near ptr M02_L63
       mov       rdx,r14
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD1A344408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    qword ptr [rbp-78],xmm0
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,22FD5C00428
       mov       rcx,[rcx]
       vmovsd    xmm0,qword ptr [rbp-78]
       vmovsd    qword ptr [rbp-118],xmm0
       call      qword ptr [7FFD1A46F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovsd    xmm0,qword ptr [rbp-118]
       mov       rdx,22F80208A50
       call      qword ptr [7FFD1A48FA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,22F80208808
       mov       r8,22F802088F0
       call      qword ptr [7FFD1A346B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L62
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L62:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L63:
       mov       rcx,22F80203C58
       cmp       r15,rcx
       jne       near ptr M02_L65
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       cmp       [rax],al
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFD1A3472A0]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,22F80208808
       mov       r8,22F802088F0
       call      qword ptr [7FFD1A346B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L64
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L64:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L65:
       mov       rdx,22F80208A68
       cmp       r15,rdx
       jne       near ptr M02_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD1A344408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,22FD5C00428
       mov       r8,[r8]
       mov       rdx,22F802067B8
       call      qword ptr [7FFD1A9BF8E8]
       mov       r14,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L66
       mov       rcx,22F80208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L67
M02_L66:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L67:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L68
       mov       rcx,22F8020887C
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L69
M02_L68:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208870
       call      qword ptr [7FFD1A4658F0]
M02_L69:
       lea       rcx,[rbp-68]
       mov       rdx,r14
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L70
       mov       rcx,22F80208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L71
M02_L70:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L71:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L72
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L72:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L73:
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L74
       mov       rcx,22F80208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L75
M02_L74:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L75:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        short M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L76
       mov       rcx,22F8020887C
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L77
M02_L76:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208870
       call      qword ptr [7FFD1A4658F0]
M02_L77:
       lea       rcx,[rbp-68]
       mov       r8,r14
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5C6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       r14d,[rbp-58]
       cmp       r14d,[rbp-48]
       jbe       short M02_L79
M02_L78:
       call      qword ptr [7FFD1A4DE9D0]
       int       3
M02_L79:
       mov       rcx,[rbp-50]
       mov       edx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r14d
       cmp       edx,1
       jb        short M02_L80
       mov       rdx,22F80208814
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L81
M02_L80:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
M02_L81:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L82
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L82:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A3FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L83:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M02_L07
M02_L84:
       mov       rcx,22F80208A90
       mov       rdx,22F80208AA8
       call      qword ptr [7FFD1A346B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M02_L25
M02_L85:
       call      qword ptr [7FFD1A4DEF40]
       int       3
M02_L86:
       mov       rcx,22FD5C01F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L87:
       xor       ecx,ecx
       test      rcx,rcx
       jne       near ptr M02_L04
M02_L88:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A94C048]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A34F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L89:
       mov       rcx,[rbp-150]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M02_L05
M02_L90:
       mov       rcx,22F80208848
       cmp       r15,rcx
       je        near ptr M02_L08
       mov       rdx,r15
       mov       rcx,22F80208890
       call      qword ptr [7FFD1A28A7B0]; Precode of System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M02_L50
       jmp       near ptr M02_L33
M02_L91:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M02_L09
M02_L92:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
       jmp       near ptr M02_L10
M02_L93:
       xor       r15d,r15d
       jmp       near ptr M02_L17
M02_L94:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L16
M02_L95:
       lea       rcx,[rbp-68]
       mov       rdx,r15
       call      qword ptr [7FFD1A4658F0]
       jmp       near ptr M02_L18
M02_L96:
       mov       rcx,r13
       call      qword ptr [7FFD1A50D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L97:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFD1A94E2C8]
       mov       r14,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A1F4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFD1A34F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M02_L98:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       cmp       byte ptr [rbp-54],0
       je        near ptr M02_L12
M02_L99:
       lea       rcx,[rbp-68]
       mov       rdx,r12
       call      qword ptr [7FFD1A465848]
       jmp       near ptr M02_L13
M02_L100:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208870
       call      qword ptr [7FFD1A4658F0]
       jmp       near ptr M02_L14
M02_L101:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A465938]
M02_L102:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A3443C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       r9,[rbp-50]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rbp-48]
       sub       r8d,edx
       xor       edx,edx
       mov       [rbp-128],r9
       mov       [rbp-120],r8d
       mov       [rbp-138],rdx
       xor       edx,edx
       mov       [rbp-130],edx
       mov       rdx,[rbp-68]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-128]
       lea       r9,[rbp-138]
       lea       r8,[rbp-0E0]
       mov       r11,7FFD1A200718
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L101
       mov       ecx,[rbp-58]
       add       ecx,[rbp-0E0]
       mov       [rbp-58],ecx
       jmp       near ptr M02_L18
M02_L103:
       lea       rcx,[rbp-68]
       mov       rdx,22F80208808
       call      qword ptr [7FFD1A4658F0]
       jmp       near ptr M02_L19
M02_L104:
       mov       rcx,[r13+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L123
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-0E4],eax
       jne       short M02_L105
       mov       rcx,r13
       mov       edx,r14d
       call      qword ptr [7FFD1A50D7E8]
       mov       r10,rax
M02_L105:
       mov       r10,[r10+8]
       mov       [rbp-188],r10
       mov       rcx,7FFD1A285120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A285C38],0
       je        short M02_L106
       call      qword ptr [7FFD1A34DC98]
       mov       edx,eax
       mov       [rbp-100],edx
       jmp       short M02_L109
M02_L106:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-104],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-104]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L107
       call      qword ptr [7FFD1A9675E8]
       mov       edx,eax
       jmp       short M02_L108
M02_L107:
       mov       edx,ecx
       sar       edx,10
M02_L108:
       mov       [rbp-100],edx
M02_L109:
       mov       rcx,7FFD1A285120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-100]
       xor       edx,edx
       div       dword ptr [7FFD1A285C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L116
M02_L110:
       cmp       eax,[r8+8]
       jae       near ptr M02_L123
       mov       [rbp-0F8],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-190],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-108],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-190]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-10C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L112
       test      r10d,r10d
       jne       short M02_L113
       xor       edx,edx
       mov       [rax+14],edx
M02_L111:
       movsxd    rdx,r10d
       mov       r8,[rbp-180]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-10C]
       inc       ecx
       mov       rax,[rbp-190]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-108],1
M02_L112:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-108]
       test      ecx,ecx
       je        short M02_L114
       mov       r8d,1
       jmp       short M02_L117
M02_L113:
       jmp       short M02_L111
M02_L114:
       mov       eax,[rbp-0F8]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-188]
       cmp       [rcx+8],r8d
       jne       short M02_L115
       xor       r8d,r8d
M02_L115:
       mov       edx,[rbp-0FC]
       inc       edx
       mov       eax,r8d
M02_L116:
       mov       r8,[rbp-188]
       mov       [rbp-0FC],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L110
       xor       r8d,r8d
M02_L117:
       mov       eax,r8d
       mov       [rbp-0E8],eax
       mov       eax,[rbp-0E4]
       jmp       near ptr M02_L21
M02_L118:
       mov       rdx,r10
       mov       r8d,eax
       mov       eax,[rbp-0E8]
       cmp       dword ptr [r15+8],0
       mov       [rbp-168],rdx
       mov       [rbp-0E4],r8d
       mov       [rbp-0E8],eax
       je        near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0EC],eax
       mov       edx,[r15+8]
       mov       [rbp-0F0],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-168]
       mov       r8d,[rbp-0EC]
       mov       r9d,[rbp-0F0]
       mov       edx,3
       call      qword ptr [7FFD1A3F7678]
       mov       eax,[rbp-0E4]
       test      [rbp-0E8],eax
       mov       [rbp-0E4],eax
       jne       near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rbp-168]
       mov       [rbp-170],rdx
       mov       [rbp-0F4],eax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[rbp-0E4]
       test      r13d,r13d
       jne       short M02_L119
       mov       r14,[rbp-170]
       mov       edx,[rbp-0F4]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L120
M02_L119:
       mov       rdx,[rbp-170]
       mov       ecx,[rbp-0F4]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L120:
       mov       r8d,r15d
       mov       r9d,eax
       test      r13d,r13d
       jne       short M02_L121
       mov       eax,1
       jmp       short M02_L122
M02_L121:
       xor       eax,eax
M02_L122:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFD1A50E2B0]
       jmp       near ptr M02_L22
M02_L123:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L124:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1D0]
       mov       rdx,[rbp-160]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD1A344348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L125
       mov       rcx,rax
       mov       r11,7FFD1A200708
       call      qword ptr [r11]
M02_L125:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 6678
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,2D8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M03_L01:
       vmovdqa   xmmword ptr [rsp+rax+2D0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2F0],xmm4
       add       rax,30
       jne       short M03_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M03_L67
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+238]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD1A2966D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+248],0
       je        near ptr M03_L65
       cmp       dword ptr [rsp+248],1
       jne       near ptr M03_L66
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+240]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M03_L02:
       mov       rcx,22FD5C04E90
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M03_L18
M03_L03:
       mov       rcx,22FD5C04E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M03_L05
M03_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD1A7565E0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r15,rax
       cmp       [rbx],r14
       jne       near ptr M03_L74
       mov       rcx,rbx
       jmp       near ptr M03_L19
M03_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,22FD5C04E88
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A752460
       mov       [r12+18],rcx
       mov       rcx,22FD5C04E98
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       short M03_L04
M03_L06:
       mov       r12d,1
       xor       ebx,ebx
       mov       [rsp+118],rbx
       xor       eax,eax
       mov       [rsp+110],rax
       xor       r10d,r10d
       mov       [rsp+108],r10
       xor       r9d,r9d
       mov       [rsp+100],r9
M03_L07:
       mov       r11,rdi
       mov       r8d,ebp
       test      r8d,r8d
       je        near ptr M03_L77
       movzx     ecx,word ptr [r11]
       cmp       ecx,7B
       je        near ptr M03_L17
       cmp       ecx,7D
       je        near ptr M03_L16
       cmp       ecx,22
       jne       near ptr M03_L14
       cmp       r12d,9
       jne       near ptr M03_L11
M03_L08:
       mov       edx,7
M03_L09:
       mov       ecx,edx
       mov       [rsp+234],ecx
       cmp       ecx,6
       je        short M03_L10
       cmp       ecx,7
       jne       near ptr M03_L23
M03_L10:
       cmp       ecx,6
       jne       near ptr M03_L20
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+208],xmm0
       cmp       r8d,1
       jb        near ptr M03_L129
       add       r11,2
       sub       r8d,1
       mov       [rsp+50],r11
       mov       [rsp+13C],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD1A5C56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+21C],eax
       cmp       eax,[rsp+13C]
       ja        near ptr M03_L129
       mov       rcx,[rsp+50]
       mov       [rsp+208],rcx
       mov       [rsp+210],eax
       lea       rcx,[rsp+208]
       call      qword ptr [7FFD1A3FC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+48],rax
       mov       edx,[rsp+21C]
       add       edx,2
       mov       [rsp+138],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+90],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+138]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+90]
       jmp       near ptr M03_L21
M03_L11:
       mov       edx,6
       jmp       near ptr M03_L09
M03_L12:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+234]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
       mov       r10,r8
       mov       r8,r10
M03_L13:
       mov       rdx,r8
       mov       [rsp+0F8],rdx
       mov       r8d,[rdx+10]
       mov       [rsp+2D4],r8d
       mov       r11d,[rdx+14]
       mov       [rsp+2D0],r11d
       cmp       r8d,2
       je        near ptr M03_L64
       jmp       short M03_L15
M03_L14:
       cmp       ecx,3A
       jne       near ptr M03_L68
       mov       edx,9
       jmp       near ptr M03_L09
M03_L15:
       cmp       r8d,8
       je        near ptr M03_L24
       cmp       r8d,5
       jne       near ptr M03_L22
       mov       r8d,[rsp+2D4]
       jmp       near ptr M03_L24
M03_L16:
       mov       edx,5
       jmp       near ptr M03_L09
M03_L17:
       mov       edx,4
       jmp       near ptr M03_L09
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,22FD5C04E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A752448
       mov       [r13+18],rcx
       mov       rcx,22FD5C04E90
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L03
M03_L19:
       test      rcx,rcx
       je        near ptr M03_L75
       cmp       [rcx],r14
       jne       near ptr M03_L75
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A296E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M03_L76
       jmp       near ptr M03_L06
M03_L20:
       cmp       ecx,7
       jne       near ptr M03_L79
       test      r8d,r8d
       je        near ptr M03_L130
       movzx     ecx,word ptr [r11]
       cmp       ecx,22
       jne       near ptr M03_L78
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       cmp       r8d,1
       jb        near ptr M03_L129
       add       r11,2
       sub       r8d,1
       mov       [rsp+40],r11
       mov       [rsp+134],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD1A5C56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+204],eax
       cmp       eax,[rsp+134]
       ja        near ptr M03_L129
       mov       rcx,[rsp+40]
       mov       [rsp+1F0],rcx
       mov       [rsp+1F8],eax
       lea       rcx,[rsp+1F0]
       call      qword ptr [7FFD1A3FC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+38],rax
       mov       edx,[rsp+204]
       add       edx,2
       mov       [rsp+130],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+130]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
M03_L21:
       mov       r8,rax
       jmp       near ptr M03_L13
M03_L22:
       mov       r8d,[rsp+2D4]
       cmp       r8d,4
       jne       near ptr M03_L51
       jmp       near ptr M03_L59
M03_L23:
       cmp       ecx,3
       je        near ptr M03_L80
       jmp       near ptr M03_L12
M03_L24:
       cmp       r12d,7
       jne       near ptr M03_L50
       mov       rax,[rsp+110]
       test      rax,rax
       je        near ptr M03_L49
       cmp       dword ptr [rax+10],6
       jne       near ptr M03_L48
       mov       [rsp+110],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        near ptr M03_L47
       mov       r10,[rsp+108]
       test      r10,r10
       je        near ptr M03_L46
       mov       [rsp+108],r10
       cmp       dword ptr [r10+10],9
       jne       near ptr M03_L45
       mov       r9,[rsp+100]
       test      r9,r9
       je        near ptr M03_L44
       cmp       dword ptr [r9+10],7
       jne       near ptr M03_L43
       mov       [rsp+100],r9
       movzx     ebx,byte ptr [r9+18]
M03_L25:
       test      ebx,ebx
       je        near ptr M03_L42
       mov       [rsp+0B0],rcx
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M03_L41
       mov       rax,offset MT_System.String
       cmp       [rbx],rax
       jne       near ptr M03_L122
M03_L26:
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD1A34EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M03_L22
       mov       rbx,[rax]
       xor       ecx,ecx
       mov       [rsp+178],ecx
       mov       [rsp+180],ecx
       mov       [rsp+18C],ecx
       mov       [rsp+190],rcx
       mov       byte ptr [rsp+198],0
       mov       byte ptr [rsp+1A0],0
       mov       byte ptr [rsp+1A8],0
       mov       [rsp+1B0],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+1B8],xmm0
       mov       [rsp+1C8],rcx
       mov       [rsp+1D0],rcx
       mov       [rsp+1D8],ecx
       mov       [rsp+1E0],ecx
       mov       [rsp+1E8],rcx
       mov       rax,[rsp+100]
       cmp       byte ptr [rax+18],0
       je        near ptr M03_L40
       mov       [rsp+100],rax
       mov       rdx,[rax+8]
       mov       [rsp+88],rdx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L84
       mov       rcx,rbx
       cmp       qword ptr [rcx+38],0
       je        near ptr M03_L62
M03_L27:
       mov       rcx,[rbx+38]
       mov       r10,[rcx+18]
M03_L28:
       mov       r9,r10
       mov       [rsp+78],r9
       mov       rcx,22F80200020
       cmp       r9,rcx
       jne       near ptr M03_L82
M03_L29:
       mov       rcx,offset MT_System.String
       mov       rdx,[rsp+88]
       cmp       [rdx],rcx
       jne       near ptr M03_L85
       mov       rcx,rdx
M03_L30:
       test      rcx,rcx
       je        short M03_L31
       mov       rdx,22F80208AE8
       xor       r8d,r8d
       call      qword ptr [7FFD1A3462F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L83
M03_L31:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L89
       cmp       qword ptr [rbx+20],0
       je        near ptr M03_L86
       mov       rbx,[rbx+20]
M03_L32:
       test      rbx,rbx
       je        near ptr M03_L123
       cmp       qword ptr [rbx+48],0
       je        near ptr M03_L61
M03_L33:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       je        short M03_L34
       mov       rcx,rbx
       call      qword ptr [7FFD1A5358F0]
M03_L34:
       test      byte ptr [rbx+5C],10
       jne       short M03_L37
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L87
       mov       rcx,[rbx+38]
       cmp       [rcx],r14
       jne       near ptr M03_L88
M03_L35:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M03_L36:
       test      eax,eax
       je        near ptr M03_L124
M03_L37:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M03_L60
M03_L38:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M03_L125
       cmp       qword ptr [rbx+48],0
       je        near ptr M03_L58
M03_L39:
       mov       rax,[rsp+88]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbx+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A5379C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       jmp       near ptr M03_L22
M03_L40:
       mov       [rsp+100],rax
       jmp       near ptr M03_L22
M03_L41:
       jmp       near ptr M03_L26
M03_L42:
       jmp       near ptr M03_L22
M03_L43:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       jmp       near ptr M03_L81
M03_L44:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       jmp       near ptr M03_L81
M03_L45:
       jmp       near ptr M03_L22
M03_L46:
       mov       [rsp+108],r10
       jmp       near ptr M03_L22
M03_L47:
       jmp       near ptr M03_L22
M03_L48:
       mov       [rsp+110],rax
       jmp       near ptr M03_L22
M03_L49:
       mov       [rsp+110],rax
       jmp       near ptr M03_L22
M03_L50:
       jmp       near ptr M03_L22
M03_L51:
       cmp       r8d,0A
       je        near ptr M03_L110
M03_L52:
       cmp       r8d,5
       je        near ptr M03_L63
       cmp       r8d,8
       je        short M03_L54
       cmp       r8d,3
       je        short M03_L54
       cmp       r8d,6
       je        near ptr M03_L56
       cmp       r8d,9
       je        near ptr M03_L57
       cmp       r8d,7
       jne       short M03_L53
       mov       rdx,[rsp+0F8]
       mov       r9,rdx
       mov       [rsp+100],r9
       jmp       short M03_L54
M03_L53:
       cmp       r8d,4
       jne       short M03_L54
       mov       rbx,[rsp+118]
       test      rbx,rbx
       mov       [rsp+118],rbx
       jne       short M03_L54
       mov       rdx,[rsp+0F8]
       mov       rbx,rdx
       mov       [rsp+118],rbx
M03_L54:
       cmp       r8d,3
       je        short M03_L55
       mov       r12d,r8d
M03_L55:
       mov       r11d,[rsp+2D0]
       cmp       r11d,ebp
       ja        near ptr M03_L129
       mov       ecx,r11d
       lea       rdi,[rdi+rcx*2]
       sub       ebp,r11d
       jmp       near ptr M03_L07
M03_L56:
       mov       rdx,[rsp+0F8]
       mov       rax,rdx
       mov       [rsp+110],rax
       jmp       short M03_L54
M03_L57:
       mov       rdx,[rsp+0F8]
       mov       r10,rdx
       mov       [rsp+108],r10
       jmp       short M03_L54
M03_L58:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD1A5378A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L39
M03_L59:
       cmp       r12d,9
       je        near ptr M03_L107
       jmp       near ptr M03_L51
M03_L60:
       mov       rcx,rbx
       call      qword ptr [7FFD1A535920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M03_L38
M03_L61:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD1A5378A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L33
M03_L62:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+68],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+68]
       mov       [rsp+168],rdx
       mov       [rsp+170],rax
       lea       rdx,[rsp+148]
       mov       [rsp+20],rdx
       mov       edx,[rbx+50]
       lea       rcx,[rsp+168]
       lea       r8,[rsp+160]
       lea       r9,[rsp+158]
       call      qword ptr [7FFD1A5957E8]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+150]
       mov       [rsp+140],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+70],rax
       mov       r9,[rbx+30]
       mov       rcx,rax
       mov       rdx,[rsp+140]
       mov       r8d,[rsp+148]
       call      qword ptr [7FFD1A537B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[rbx+38]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L27
M03_L63:
       mov       r11d,[rsp+2D0]
       cmp       r11d,ebp
       ja        near ptr M03_L129
       mov       ecx,r11d
       lea       rdi,[rdi+rcx*2]
       sub       ebp,r11d
M03_L64:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,2D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L65:
       mov       rdx,22FD5C01F30
       mov       r15,[rdx]
       jmp       near ptr M03_L02
M03_L66:
       lea       rdx,[rsp+238]
       mov       r8d,[rsp+248]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD1A50FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+248]
       mov       [rsp+24C],ecx
       mov       r15,[rsp+238]
       jmp       near ptr M03_L02
M03_L67:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M03_L02
M03_L68:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       cmp       ecx,2C
       jne       short M03_L69
       mov       edx,8
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L69:
       cmp       ecx,5B
       jne       short M03_L70
       mov       edx,0A
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L70:
       cmp       ecx,5D
       jne       short M03_L71
       mov       edx,0B
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L71:
       cmp       ecx,20
       jne       short M03_L72
       mov       edx,3
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L72:
       cmp       r12d,9
       je        short M03_L73
       xor       edx,edx
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L73:
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L08
M03_L74:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L19
M03_L75:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD1A94C660]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD1A1F4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD1A34F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L76:
       mov       [rsp+258],rdi
       mov       [rsp+260],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+250]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+260]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,2D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L77:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       edx,2
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L09
M03_L78:
       mov       [rsp+120],r11
       mov       [rsp+128],r8d
       lea       rdx,[rsp+120]
       lea       rcx,[rsp+220]
       call      qword ptr [7FFD1A72FC90]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       edx,7
       mov       r8d,[rsp+228]
       call      qword ptr [7FFD1A756388]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+220]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       jmp       near ptr M03_L21
M03_L79:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+234]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M03_L21
M03_L80:
       mov       [rsp+120],r11
       mov       [rsp+128],r8d
       lea       rcx,[rsp+120]
       call      qword ptr [7FFD1A72FC48]
       mov       [rsp+230],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r10,rax
       mov       [rsp+0A8],r10
       mov       rcx,r10
       mov       edx,3
       mov       r8d,[rsp+230]
       call      qword ptr [7FFD1A756388]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r10,[rsp+0A8]
       mov       rcx,r10
       mov       r8,rcx
       jmp       near ptr M03_L13
M03_L81:
       xor       ebx,ebx
       mov       [rsp+100],r9
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L25
M03_L82:
       mov       rcx,r9
       mov       r8,[r9]
       mov       r8,[r8+98]
       call      qword ptr [r8+20]
       mov       rcx,22F802021B8
       cmp       rax,rcx
       je        near ptr M03_L29
       mov       r9,[rsp+78]
       mov       rcx,r9
       mov       r8,[r9]
       mov       r8,[r8+58]
       call      qword ptr [r8+10]
       test      eax,eax
       jne       near ptr M03_L29
       mov       r9,[rsp+78]
       mov       rdx,[rsp+88]
       mov       rcx,rdx
       test      rcx,rcx
       je        near ptr M03_L91
       jmp       near ptr M03_L90
M03_L83:
       mov       rcx,rbx
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       jmp       near ptr M03_L22
M03_L84:
       mov       rcx,rbx
       mov       r9,[rbx]
       mov       r9,[r9+50]
       call      qword ptr [r9+10]
       mov       rcx,rax
       mov       r10,rcx
       jmp       near ptr M03_L28
M03_L85:
       mov       rcx,rdx
       mov       r8,[rdx]
       mov       r8,[r8+40]
       call      qword ptr [r8+8]
       mov       rcx,rax
       jmp       near ptr M03_L30
M03_L86:
       xor       ebx,ebx
       jmp       near ptr M03_L32
M03_L87:
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M03_L35
M03_L88:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M03_L36
M03_L89:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,[rsp+88]
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       jmp       near ptr M03_L22
M03_L90:
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M03_L126
M03_L91:
       mov       rdx,22F80204FE8
       cmp       r9,rdx
       jne       short M03_L92
       lea       r9,[rsp+178]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A29DC98]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+178]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L92:
       mov       rdx,22F80208938
       cmp       r9,rdx
       jne       short M03_L93
       lea       r9,[rsp+180]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2F48B8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+180]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L93:
       mov       rdx,22F80208A28
       cmp       r9,rdx
       jne       short M03_L94
       lea       r9,[rsp+18C]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2FC840]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       vmovss    xmm0,dword ptr [rsp+18C]
       vmovss    dword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L94:
       mov       rdx,22F80205740
       cmp       r9,rdx
       jne       short M03_L95
       lea       r9,[rsp+190]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFD1A32C648]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       vmovsd    xmm0,qword ptr [rsp+190]
       vmovsd    qword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L95:
       mov       rdx,22F80203C58
       cmp       r9,rdx
       jne       near ptr M03_L98
       test      rcx,rcx
       jne       short M03_L96
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M03_L97
M03_L96:
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
M03_L97:
       mov       [rsp+120],rdx
       mov       [rsp+128],r8d
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+198]
       call      qword ptr [7FFD1A29CA98]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+198]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L98:
       mov       rdx,22F80208988
       cmp       r9,rdx
       jne       short M03_L99
       lea       r9,[rsp+1A0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2DD2D8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1A0]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L99:
       mov       rdx,22F802089B0
       cmp       r9,rdx
       jne       short M03_L100
       lea       r9,[rsp+1A8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2DC2B8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1A8]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L100:
       mov       rdx,22F80208848
       cmp       r9,rdx
       jne       short M03_L101
       lea       rdx,[rsp+1B0]
       call      qword ptr [7FFD1A2D5B60]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1B0]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L101:
       mov       rdx,22F802089D8
       cmp       r9,rdx
       jne       short M03_L102
       lea       r9,[rsp+1B8]
       mov       edx,6F
       xor       r8d,r8d
       call      qword ptr [7FFD1A464558]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       vmovups   xmm0,[rsp+1B8]
       vmovups   [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L102:
       mov       rdx,22F80205F80
       cmp       r9,rdx
       jne       short M03_L103
       lea       r9,[rsp+1C8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2F59C8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1C8]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L103:
       mov       rdx,22F80208960
       cmp       r9,rdx
       jne       short M03_L104
       lea       r9,[rsp+1D0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2F6AF0]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1D0]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L104:
       mov       rdx,22F80208910
       cmp       r9,rdx
       jne       short M03_L105
       lea       r9,[rsp+1D8]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2DE580]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1D8]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L105:
       mov       rdx,22F80208610
       cmp       r9,rdx
       jne       short M03_L106
       lea       r9,[rsp+1E0]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD1A2DF6A8]
       test      eax,eax
       mov       [rsp+80],rbx
       je        near ptr M03_L22
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+1E0]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L106:
       mov       rdx,22F80208A68
       cmp       r9,rdx
       mov       [rsp+80],rbx
       jne       near ptr M03_L22
       lea       rdx,[rsp+1E8]
       call      qword ptr [7FFD1A60F0D8]
       test      eax,eax
       je        near ptr M03_L22
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+1E8]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+80]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L107:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       [rsp+110],rax
       mov       rcx,rax
       mov       [rsp+108],r10
       mov       rdx,r10
       call      qword ptr [7FFD1A72FBD0]
       test      eax,eax
       mov       r8d,[rsp+2D4]
       je        near ptr M03_L54
       mov       r10,[rsp+108]
       mov       rax,[rsp+110]
       mov       rdx,[rax+8]
       mov       [rsp+0C0],rdx
       mov       rcx,rdx
       mov       [rsp+0B8],rcx
       test      rcx,rcx
       je        near ptr M03_L109
       mov       rax,[rsp+110]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jne       near ptr M03_L127
M03_L108:
       lea       r8,[rsp+2C8]
       mov       rcx,r15
       mov       rdx,[rsp+0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A3D4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+2D4]
       je        near ptr M03_L54
       mov       rcx,[rsp+2C8]
       mov       rdx,[rsp+2C8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       r8,[rsp+120]
       lea       rcx,[rsp+2B0]
       call      qword ptr [7FFD1A72FC00]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+2B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+100],r12
       mov       ebp,7
       mov       rdi,[rsp+2B8]
       mov       ecx,[rsp+2C0]
       mov       eax,ecx
       mov       r12d,ebp
       mov       ebp,eax
       jmp       near ptr M03_L07
M03_L109:
       mov       [rsp+108],r10
       jmp       near ptr M03_L108
M03_L110:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       cmp       r12d,9
       jne       near ptr M03_L117
       mov       [rsp+110],rax
       mov       rcx,rax
       mov       [rsp+108],r10
       mov       rdx,r10
       call      qword ptr [7FFD1A72FBD0]
       test      eax,eax
       mov       r8d,[rsp+2D4]
       je        near ptr M03_L54
       mov       rax,[rsp+110]
       mov       rdx,[rax+8]
       mov       rcx,rdx
       mov       [rsp+0D8],rcx
       test      rcx,rcx
       je        near ptr M03_L116
       mov       r11,offset MT_System.String
       cmp       [rcx],r11
       jne       near ptr M03_L128
M03_L111:
       lea       r8,[rsp+2A8]
       mov       rcx,r15
       mov       rdx,[rsp+0D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A3D4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L115
       mov       rcx,[rsp+2A8]
       mov       rdx,[rsp+2A8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       [rsp+0F0],rax
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       test      eax,eax
       je        near ptr M03_L118
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       rcx,22F80208AC0
       cmp       rax,rcx
       jne       near ptr M03_L118
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L130
       mov       r12,[rax+10]
       mov       rcx,[rsp+0F0]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A506028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3443C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E8],rax
M03_L112:
       cmp       ebp,1
       jb        near ptr M03_L129
       add       rdi,2
       lea       edx,[rbp-1]
       mov       [rsp+120],rdi
       mov       [rsp+128],edx
       mov       rdx,r12
       lea       r8,[rsp+120]
       lea       rcx,[rsp+288]
       call      qword ptr [7FFD1A72FC00]
       mov       rdi,[rsp+290]
       mov       ebp,[rsp+298]
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       rdx,[rsp+120]
       mov       ecx,1
       call      qword ptr [7FFD1A72FCC0]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+2A4],eax
       mov       rcx,[rsp+0E8]
       mov       rdx,[rsp+288]
       mov       r11,7FFD1A200658
       call      qword ptr [r11]
       mov       ecx,[rsp+2A4]
       cmp       ecx,8
       je        near ptr M03_L112
       cmp       ecx,0B
       jne       short M03_L113
       cmp       ebp,1
       jb        near ptr M03_L129
       add       rdi,2
       dec       ebp
M03_L113:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+0E8]
       call      CORINFO_HELP_ASSIGN_REF
M03_L114:
       mov       eax,7
       mov       [rsp+100],r12
       mov       r12d,eax
       jmp       near ptr M03_L07
M03_L115:
       mov       r8d,[rsp+2D4]
       jmp       near ptr M03_L54
M03_L116:
       jmp       near ptr M03_L111
M03_L117:
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L52
M03_L118:
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M03_L121
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0D0],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+0D0]
       mov       rcx,22F80208AC0
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A28A758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A506028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3443C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E0],rax
M03_L119:
       cmp       ebp,1
       jb        near ptr M03_L129
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+120],rdx
       mov       [rsp+128],r8d
       mov       rdx,r12
       lea       r8,[rsp+120]
       lea       rcx,[rsp+268]
       call      qword ptr [7FFD1A72FC00]
       mov       rdi,[rsp+270]
       mov       ebp,[rsp+278]
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       rdx,[rsp+120]
       mov       ecx,1
       call      qword ptr [7FFD1A72FCC0]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+284],eax
       mov       rcx,[rsp+0E0]
       mov       rdx,[rsp+268]
       mov       r11,7FFD1A200640
       call      qword ptr [r11]
       mov       ecx,[rsp+284]
       cmp       ecx,8
       je        near ptr M03_L119
       mov       rax,[rsp+0E0]
       cmp       ecx,0B
       jne       short M03_L120
       cmp       ebp,1
       jb        near ptr M03_L129
       add       rdi,2
       dec       ebp
M03_L120:
       mov       rcx,rax
       mov       r11,7FFD1A200648
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFD1A297678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r12,rax
       mov       rcx,[rsp+0E0]
       mov       rdx,r12
       mov       r11,7FFD1A200650
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       dword ptr [rax+10],7
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+0C8]
       jmp       near ptr M03_L114
M03_L121:
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r8d,[rsp+2D4]
       jmp       near ptr M03_L54
M03_L122:
       mov       rcx,rax
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L123:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A94CB70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A34F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L124:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD1A965188]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD1A605998]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L125:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD1A94C990]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD1A605908]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L126:
       mov       rcx,r8
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L127:
       mov       rcx,rdx
       mov       rdx,[rsp+0C0]
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L128:
       mov       rcx,r11
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L129:
       call      qword ptr [7FFD1A4DE9D0]
       int       3
M03_L130:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 7087
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD1A344348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M04_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M04_L05
M04_L00:
       mov       rax,rbx
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD1A1F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A5066E8]
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M04_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD1A94FA50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD1A7569A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD1A94FAE0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD1A7569A0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L06:
       mov       rcx,22F80203C58
       cmp       rsi,rcx
       jne       short M04_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006E8
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,22F80208848
       cmp       rsi,rcx
       jne       short M04_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006E0
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,22F802089B0
       cmp       rsi,rcx
       jne       short M04_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006D8
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L09:
       mov       rcx,22F80208988
       cmp       rsi,rcx
       jne       short M04_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006D0
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,22F80208910
       cmp       rsi,rcx
       jne       short M04_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006C8
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L11:
       mov       rcx,22F80208610
       cmp       rsi,rcx
       jne       short M04_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006C0
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L12:
       mov       rcx,22F80204FE8
       cmp       rsi,rcx
       jne       short M04_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006B8
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,22F80208938
       cmp       rsi,rcx
       jne       short M04_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006B0
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,22F80205F80
       cmp       rsi,rcx
       jne       short M04_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006A8
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,22F80208960
       cmp       rsi,rcx
       jne       short M04_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A2006A0
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,22F80208A28
       cmp       rsi,rcx
       jne       short M04_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A200698
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L17:
       mov       rcx,22F80205740
       cmp       rsi,rcx
       jne       short M04_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A200690
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,22F802089D8
       cmp       rsi,rcx
       jne       short M04_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD1A200688
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,22F80208A68
       cmp       rsi,rcx
       jne       short M04_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A200680
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L20:
       mov       rcx,22F80200020
       cmp       rsi,rcx
       jne       short M04_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A200678
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L21:
       mov       rcx,22F802021B8
       cmp       rsi,rcx
       je        near ptr M04_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD1A200670
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
M05_L03:
       jmp       qword ptr [7FFD1A3443A8]
; Total bytes of code 69
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M06_L03
       cmp       r8,4
       jae       short M06_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L00:
       test      r8b,1
       je        short M06_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M06_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L03:
       cmp       rcx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L04:
       vzeroupper
       ret
M06_L05:
       mov       eax,1
       vzeroupper
       ret
M06_L06:
       cmp       r8,20
       jb        short M06_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L08
M06_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
       add       rax,20
       cmp       r8,rax
       ja        short M06_L07
M06_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M06_L13
       nop       dword ptr [rax]
       jmp       short M06_L05
       nop       dword ptr [rax]
M06_L09:
       cmp       r8,10
       jb        short M06_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L11
M06_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L13
       add       rax,10
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L13
       jmp       near ptr M06_L05
M06_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L04
M06_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M07_L08
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M07_L00
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        near ptr M07_L05
       mov       rcx,7FFD1AB52598
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M07_L06
       jmp       near ptr M07_L07
M07_L00:
       mov       rcx,7FFD1AB52594
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L01
       jmp       short M07_L02
M07_L01:
       mov       rcx,rsi
       mov       rdx,7FFD1AB43898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rcx,rsi
       mov       rdx,7FFD1AB438A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L04:
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFD1A605308]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M07_L05:
       mov       rcx,7FFD1AB5259C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,rsi
       mov       rdx,7FFD1AB43898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M07_L03
       jmp       short M07_L04
M07_L08:
       mov       rcx,7FFD1AB52590
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD1A4DED48]
       int       3
; Total bytes of code 356
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD79CF41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD79D07B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD79D08B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftSingleMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,2B7E6804198
       mov       rdi,[rsi]
       mov       rcx,2B7E6804E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L07
       xor       ebp,ebp
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A786D78]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbp,rbp
       jne       near ptr M00_L08
M00_L01:
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFD1A784420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,2B7802090D0
       xor       r8d,r8d
       call      qword ptr [7FFD1A784510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [rbp],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD1A3643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rbp,rax
M00_L02:
       mov       r8,[rsi]
       mov       rcx,[r8+8]
       test      rbp,rbp
       je        short M00_L05
       mov       rdx,[rbp+8]
M00_L03:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L04
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A415068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L06
M00_L04:
       inc       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       edx,edx
       jmp       short M00_L03
M00_L06:
       dec       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L07:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FFD1A786DF0]
       jmp       near ptr M00_L01
; Total bytes of code 281
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,2B7E6804ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,2B7E68050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2B7E6804ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2B7E68050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2B7E6800428
       mov       r13,[rcx]
       mov       rcx,2B7E68014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2B780201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,2B7E6805078
       mov       rax,2B7E6805080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A75A950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A41D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD1A5AA130]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD1A78F540]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD1A220F18
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,2B7E6804E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD1A786D78]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD1A7919C0]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A75A950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A526640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD1A786DF0]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD1A786DF0]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD1A2210F8
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD1A221100
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD79D0B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M05_L03
       cmp       r8,4
       jae       short M05_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L00:
       test      r8b,1
       je        short M05_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M05_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L03:
       cmp       rcx,rdx
       je        short M05_L05
       jmp       short M05_L06
M05_L04:
       vzeroupper
       ret
M05_L05:
       mov       eax,1
       vzeroupper
       ret
M05_L06:
       cmp       r8,20
       jb        short M05_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L08
M05_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L13
       add       rax,20
       cmp       r8,rax
       ja        short M05_L07
M05_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       nop       dword ptr [rax]
       jmp       short M05_L05
       nop       dword ptr [rax]
M05_L09:
       cmp       r8,10
       jb        short M05_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L11
M05_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L13
       add       rax,10
       cmp       r8,rax
       ja        short M05_L10
M05_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L13
       jmp       near ptr M05_L05
M05_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L04
M05_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.STJSingleMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,2839A804198
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,2839A804F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L16
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L17
       mov       rdx,[rdi+0B8]
       mov       r8,283803087E0
       cmp       rdx,r8
       jne       near ptr M00_L17
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L10
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.StringPropertyObj ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.StringPropertyObj>)
       call      qword ptr [7FFD1A7A6EF8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rdx,2839A804F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L12
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L13
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L18
       mov       rdx,[r15+0B8]
       mov       r8,283803087E0
       cmp       rdx,r8
       jne       near ptr M00_L18
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.StringPropertyObj>)
       call      qword ptr [7FFD1A91C6D8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       r8,2839A804198
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rax,rax
       je        short M00_L09
       mov       rdx,[rax+8]
M00_L07:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L08
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L14
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A435068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L14
M00_L08:
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       xor       edx,edx
       jmp       short M00_L07
M00_L10:
       call      qword ptr [7FFD1A3843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L11:
       mov       ecx,389E
       mov       rdx,7FFD1A77A958
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A7AC018]
       int       3
M00_L12:
       mov       rcx,2839A804F48
       xor       edx,edx
       call      qword ptr [7FFD1A7A59E0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,r14
       call      qword ptr [7FFD1A7A5938]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L14:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L15:
       mov       rcx,2839A804F48
       xor       edx,edx
       call      qword ptr [7FFD1A7A59E0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFD1A7A5938]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L17:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,283803087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7A51E8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L18:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,283803087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7A51E8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L19:
       call      qword ptr [7FFD1A3843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 707
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A7A59B0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,2839A801FF8
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD1A924A48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,28380301C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD1A7A6CB8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFD1A51E9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD1A7AD908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A9172E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFD1A77C468
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2839A804F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD1A914858]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD1A916DF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD1A9149D8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFD1A51E9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD1A435BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,2839A801FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD1A924A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,228
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+200],xmm4
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+1F0],rax
       mov       [rbp],rsp
       mov       rax,7E288F459B33
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+18],rcx
       cmp       edi,55
       jg        near ptr M02_L08
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r8d,100
M02_L01:
       mov       [rbp+10],rax
       mov       [rbp+54],r8d
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       mov       rcx,[rbp+10]
       mov       [rbp+30],rcx
       mov       ecx,[rbp+54]
       mov       [rbp+38],ecx
       lea       rcx,[rbp+40]
       lea       rdx,[rbp+30]
       call      qword ptr [7FFD1A7AD968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+54]
       ja        short M02_L04
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+54],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L03
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L02
       jmp       short M02_L05
M02_L02:
       mov       ecx,347F
       mov       rdx,7FFD1A77A958
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A7AC078]
       int       3
M02_L03:
       mov       ecx,347F
       mov       rdx,7FFD1A77A958
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A7AC0C0]
       int       3
M02_L04:
       call      qword ptr [7FFD1A51E9D0]
       int       3
M02_L05:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1C0],r10
       mov       [rbp+1C8],r10
       mov       byte ptr [rbp+1D0],0
       mov       byte ptr [rbp+1D1],0
       mov       byte ptr [rbp+1D2],0
       mov       byte ptr [rbp+1D3],0
       mov       byte ptr [rbp+1D4],0
       mov       byte ptr [rbp+1D5],0
       mov       [rbp+1D8],ecx
       mov       [rbp+1DC],r8b
       mov       [rbp+1DD],r9b
       mov       byte ptr [rbp+1DE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+1E0],xmm0
       vmovdqu   xmmword ptr [rbp+1E8],xmm0
       mov       [rbp+20],rdx
       mov       [rbp+28],eax
       lea       rdx,[rbp+20]
       lea       rcx,[rbp+100]
       lea       r9,[rbp+1C0]
       mov       r8d,1
       call      qword ptr [7FFD1A91D548]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+60],ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       lea       rcx,[rbp+60]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD1A91E5F8]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+60]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+58]
       lea       rdx,[rbp+100]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A845938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rdi,[rbp+58]
       xor       edx,edx
       mov       [rbp+58],rdx
       cmp       qword ptr [rbp+18],0
       je        short M02_L06
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A435278]
       mov       rcx,2839A801FF8
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FFD1A924A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L06:
       mov       rax,rdi
       mov       rcx,7E288F459B33
       cmp       [rbp+8],rcx
       je        short M02_L07
       call      CORINFO_HELP_FAIL_FAST
M02_L07:
       nop
       lea       rsp,[rbp+1F8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L08:
       cmp       edi,15555555
       jbe       short M02_L09
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       lea       rcx,[rbp+40]
       call      qword ptr [7FFD1A7AD950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L10
M02_L09:
       lea       edx,[rdi+rdi*2]
       mov       rcx,2839A801FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFD1A924A48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+18],rax
M02_L10:
       test      rax,rax
       jne       short M02_L11
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M02_L12
M02_L11:
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       mov       ecx,eax
       mov       rax,r8
       mov       r8d,ecx
M02_L12:
       jmp       near ptr M02_L01
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+18],0
       je        short M02_L13
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A435278]
       mov       rcx,2839A801FF8
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FFD1A924A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L13:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 839
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M03_L03
       cmp       r8,4
       jae       short M03_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M03_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M03_L00:
       test      r8b,1
       je        short M03_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L03:
       cmp       rcx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L04:
       vzeroupper
       ret
M03_L05:
       mov       eax,1
       vzeroupper
       ret
M03_L06:
       cmp       r8,20
       jb        short M03_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M03_L08
M03_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M03_L13
       add       rax,20
       cmp       r8,rax
       ja        short M03_L07
M03_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       nop       dword ptr [rax]
       jmp       short M03_L05
       nop       dword ptr [rax]
M03_L09:
       cmp       r8,10
       jb        short M03_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M03_L11
M03_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M03_L13
       add       rax,10
       cmp       r8,rax
       ja        short M03_L10
M03_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M03_L13
       jmp       near ptr M03_L05
M03_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L04
M03_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD79D0B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD1A7A5368]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD1A7A4390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD1A7A7618]
       mov       [rbp-40],rax
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFD1A7A7510]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M05_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A7A53C8]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD1A7A75A0]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M05_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M05_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M06_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M06_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M06_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD1A7A4390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M06_L05
       call      qword ptr [7FFD1A7A7510]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD1A384360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M06_L03
       jmp       near ptr M06_L09
M06_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L09
M06_L03:
       call      qword ptr [7FFD1A7A7720]
       test      eax,eax
       je        near ptr M06_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD1A844450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD1A844450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD1A844480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD1A7A75E8]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M06_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A844318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A844318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A844318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A7A5938]
       jmp       short M06_L09
M06_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A844390]
       jmp       short M06_L09
M06_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD1A384360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L07
M06_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M06_L08
M06_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M06_L08:
       cmp       dword ptr [rbp-34],0
       je        short M06_L09
       call      qword ptr [7FFD1A7AC978]
M06_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A7A58F0]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M07_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A7A51A0]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A844360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       cmp       qword ptr [rbp-8],0
       je        short M07_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD1A7A65C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M07_L01
M07_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD1A7A5950]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M07_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M07_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD1A644720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M07_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A7A53B0]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD1A7ACF60]
M07_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisValueMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,2E00A8041A0
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD1A2A66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L13
       cmp       dword ptr [rsp+68],1
       je        near ptr M00_L14
       mov       edi,[rsp+68]
       test      edi,edi
       jl        near ptr M00_L15
       mov       rbp,[rsp+58]
       test      rbp,rbp
       je        near ptr M00_L16
       cmp       [rbp+8],edi
       je        short M00_L01
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       cmp       edi,r8d
       cmovg     edi,r8d
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L03
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+58],r14
M00_L01:
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rcx,[rsp+58]
M00_L02:
       mov       rdx,rsi
       call      qword ptr [7FFD1A7542D0]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       short M00_L04
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L05
M00_L03:
       call      qword ptr [7FFD1A405BD8]
       jmp       short M00_L00
M00_L04:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L05:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,2E0002087E0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD1A754390]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M00_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L17
       mov       rax,[rcx]
       add       rax,10
M00_L06:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L07
       mov       r8,2E00A800438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L07
       mov       r8,2E00A800418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L18
M00_L07:
       mov       rcx,[rsp+40]
       mov       rdx,2E0002087E0
       call      qword ptr [7FFD1A75D710]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L08
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.ValueTestObject
       cmp       [rsi],rcx
       je        short M00_L08
       mov       rdx,rax
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M00_L08:
       mov       r8,2E00A8041A0
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rsi,rsi
       je        short M00_L11
       mov       rdx,[rsi+8]
M00_L09:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L10
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L12
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A405068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L12
M00_L10:
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L11:
       xor       edx,edx
       jmp       short M00_L09
M00_L12:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L13:
       mov       rcx,2E00A801F30
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
       jmp       near ptr M00_L02
M00_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD1A4EED48]
       int       3
M00_L16:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+58],rax
       jmp       near ptr M00_L01
M00_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L06
M00_L18:
       call      qword ptr [7FFD1A494030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L07
; Total bytes of code 698
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r14,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       rsi,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rdi,rdi
       je        near ptr M01_L03
       test      bl,1
       je        short M01_L00
       mov       rdx,rdi
       mov       rcx,2E00A800590
       mov       rcx,[rcx]
       call      qword ptr [7FFD1A754600]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rdi+8]
       mov       eax,ecx
       cmp       word ptr [rdi+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rdi
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L23
       test      r15d,r15d
       je        near ptr M01_L11
       cmp       ecx,r15d
       je        near ptr M01_L10
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r15d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L12
       mov       r14,rax
M01_L05:
       mov       [rsp+38],rdi
       cmp       [r14],r14b
       lea       rdx,[r14+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       r14,r8
       cmp       [r14],r14b
       cmp       r12d,1
       je        near ptr M01_L13
       cmp       r12d,2
       je        near ptr M01_L15
       jmp       near ptr M01_L17
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,r14
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       lea       rcx,[rsp+50]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD1A544FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rsp+4C]
M01_L09:
       inc       ecx
       cmp       r14d,ecx
       jg        near ptr M01_L20
       jmp       near ptr M01_L22
M01_L10:
       mov       rdi,r12
       jmp       near ptr M01_L02
M01_L11:
       mov       rdi,2E000200008
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,r14
       call      qword ptr [7FFD1A2A6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L13:
       lea       rcx,[r14+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A545050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L14
       mov       rcx,r14
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD1A546838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L14:
       mov       r12,rax
       jmp       short M01_L19
M01_L15:
       lea       rcx,[r14+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD1A545050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L16
       mov       rcx,r14
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD1A546838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L16:
       jmp       short M01_L19
M01_L17:
       cmp       byte ptr [r14+18],0
       je        short M01_L18
       mov       r12,[r14+8]
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD1A546838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L19:
       xor       ebx,2
       mov       r14d,[r12+8]
       mov       ecx,r14d
       xor       edx,edx
       mov       [rsp+50],rdx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M01_L22
M01_L20:
       mov       edx,ecx
       mov       rax,[r12+rdx*8+10]
       mov       [rsp+40],rax
       mov       edx,[rax+58]
       mov       r8d,ebx
       and       r8d,edx
       cmp       r8d,edx
       jne       near ptr M01_L09
       test      r15d,r15d
       jne       short M01_L24
       test      rsi,rsi
       jne       short M01_L21
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L08
M01_L21:
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L25
M01_L22:
       mov       rdx,[rsp+50]
       mov       rcx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rbp+10],eax
       mov       eax,[rsp+64]
       mov       [rbp+14],eax
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFD1A357258]
       int       3
M01_L24:
       mov       [rsp+4C],ecx
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8d,r13d
       call      qword ptr [7FFD1A2A6538]
       test      eax,eax
       mov       ecx,[rsp+4C]
       je        near ptr M01_L09
       mov       rax,[rsp+40]
       test      rsi,rsi
       mov       [rsp+4C],ecx
       je        near ptr M01_L08
M01_L25:
       mov       rcx,rax
       call      qword ptr [7FFD1A5FD8F0]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[rsi+8]
       mov       ecx,[rsp+4C]
       jne       near ptr M01_L09
       mov       rax,[rsp+40]
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L08
; Total bytes of code 879
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2A8
       vzeroupper
       lea       rbp,[rsp+2E0]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-2B0],rsp
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L132
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       [rbp-210],rdi
       mov       [rbp-218],rsi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,[rbp-3C]
       mov       rcx,[rsi+rcx*8+10]
       mov       [rbp-220],rcx
       mov       rcx,[rbp-220]
       mov       r14,[rcx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L135
       mov       rcx,[rbp-220]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L133
       test      rcx,rcx
       je        near ptr M02_L134
M02_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD1A533280]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r13,rax
M02_L05:
       cmp       r14,r15
       jne       near ptr M02_L131
       mov       r12,[rbp-220]
       mov       rcx,[rbp-220]
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L130
M02_L06:
       mov       rcx,[r12+38]
       mov       r12,[rcx+18]
M02_L07:
       test      r13,r13
       je        near ptr M02_L117
       mov       rcx,2E000200020
       cmp       r12,rcx
       je        near ptr M02_L81
       mov       rcx,2E000208848
       cmp       r12,rcx
       je        near ptr M02_L81
       test      r12,r12
       je        short M02_L10
       mov       rcx,2E000208890
       cmp       r12,rcx
       je        near ptr M02_L141
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M02_L136
       mov       rcx,r12
       test      rcx,rcx
       je        near ptr M02_L137
M02_L08:
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M02_L137
       mov       rdx,2E000208890
       call      System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L09:
       test      eax,eax
       jne       near ptr M02_L141
M02_L10:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M02_L43
       mov       rcx,r12
       call      qword ptr [7FFD1A2A7330]; System.RuntimeType.GetBaseType()
M02_L11:
       mov       rcx,2E0002021B8
       cmp       rax,rcx
       je        near ptr M02_L44
M02_L12:
       mov       rcx,2E000208910
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,2E000208610
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,2E000204FE8
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,2E000208938
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E000205F80
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E000208960
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E000208988
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E0002089B0
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E0002089D8
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E000204BB0
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,2E000208A00
       cmp       r12,rcx
       jne       near ptr M02_L74
M02_L13:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,2E00A801EE8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFD1A529EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M02_L46
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L14:
       mov       [rbp-50],r8
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L47
       mov       rdx,2E000208814
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-58]
       inc       edx
       mov       [rbp-58],edx
M02_L15:
       mov       rdx,[rbp-220]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L48
       mov       r14,[rbp-220]
       mov       rdx,[rbp-220]
       mov       rdx,[rdx+8]
       test      rdx,rdx
       je        near ptr M02_L25
M02_L16:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L49
M02_L17:
       test      rdx,rdx
       je        near ptr M02_L49
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,r8d
       mov       r14d,[rdx+8]
       cmp       r14d,eax
       ja        near ptr M02_L49
       add       rdx,0C
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rbp-58]
       mov       [rbp-58],r14d
M02_L18:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       r8,[rbp-50]
       mov       edx,ecx
       lea       r8,[r8+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,2
       jb        near ptr M02_L50
       mov       rcx,2E0002088FC
       mov       edx,[rcx]
       mov       [r8],edx
       mov       ecx,[rbp-58]
       add       ecx,2
       mov       [rbp-58],ecx
M02_L19:
       lea       rcx,[rbp-68]
       mov       r8,r13
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5D6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rax,[rbp-50]
       mov       [rbp-1F8],rax
       mov       [rbp-1F0],ecx
       lea       rcx,[rbp-1F8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r14,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r14,r14
       je        near ptr M02_L22
       mov       ecx,[r14+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,7FFD1A295120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L52
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-150],1
       cmp       [rcx+8],r15d
       jbe       short M02_L21
       mov       dword ptr [rbp-14C],1
       mov       edx,10
       shlx      edx,edx,r15d
       cmp       [r14+8],edx
       jne       near ptr M02_L53
       mov       edx,r15d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-288],r10
       mov       r9,[r10]
       mov       [rbp-290],r9
       mov       rcx,r10
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-288]
       mov       [rdx+8],ecx
       mov       rax,[rbp-290]
       test      rax,rax
       mov       [rbp-290],rax
       mov       eax,[rbp-14C]
       jne       near ptr M02_L54
M02_L21:
       mov       rcx,2E00A8005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L68
M02_L22:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L73
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       mov       edx,[rbp-3C]
       inc       edx
       mov       [rbp-3C],edx
       mov       edx,[rsi+8]
       cmp       edx,[rbp-3C]
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,2E000200C60
       call      qword ptr [7FFD1A356DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,2E000208A90
       mov       r8,2E000208AA8
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,2A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L25:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-138],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rbp-138]
       call      qword ptr [7FFD1A546B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-138]
       vmovups   [rbp-148],xmm0
       lea       rcx,[rbp-148]
       call      qword ptr [7FFD1A546BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       jmp       near ptr M02_L16
M02_L26:
       jmp       near ptr M02_L34
M02_L27:
       mov       rcx,[rbp-230]
       mov       r11,7FFD1A2107B0
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,2E000200020
       cmp       rax,rcx
       je        short M02_L28
       mov       rcx,2E000208848
       cmp       rax,rcx
       jne       near ptr M02_L30
M02_L28:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,2E000208808
       mov       r8,2E000208808
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,[rbp-228]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-228]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-228]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L29
       lea       r8d,[rdx+1]
       mov       r10,[rbp-228]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L34
M02_L29:
       mov       rcx,[rbp-228]
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L34
M02_L30:
       mov       rcx,rax
       call      qword ptr [7FFD1A2A7330]; System.RuntimeType.GetBaseType()
       mov       rcx,2E0002021B8
       cmp       rax,rcx
       jne       short M02_L32
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,rax
       mov       edx,1C
       call      qword ptr [7FFD1A29A6C8]; System.RuntimeType.GetProperties(System.Reflection.BindingFlags)
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD1A7542D0]
       mov       rcx,[rbp-228]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-228]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-228]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L31
       lea       r8d,[rdx+1]
       mov       r10,[rbp-228]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L34
M02_L31:
       mov       rcx,[rbp-228]
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L34
M02_L32:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rbp-228]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-228]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-228]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L33
       lea       r8d,[rdx+1]
       mov       r10,[rbp-228]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L34
M02_L33:
       mov       rcx,[rbp-228]
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L34:
       mov       rcx,[rbp-230]
       mov       r11,7FFD1A2107A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L27
       mov       rcx,rsp
       call      M02_L189
       nop
M02_L35:
       mov       rdx,[rbp-228]
       mov       rcx,2E000200C60
       call      qword ptr [7FFD1A356DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       r13,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L36
       mov       rcx,2E000208814
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L37
M02_L36:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A4758F0]
M02_L37:
       mov       rcx,[rbp-220]
       mov       rax,[rbp-220]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L38
       mov       rcx,2E0002088C4
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L39
M02_L38:
       lea       rcx,[rbp-68]
       mov       rdx,2E0002088B8
       call      qword ptr [7FFD1A4758F0]
M02_L39:
       lea       rcx,[rbp-68]
       mov       rdx,r13
       call      qword ptr [7FFD1A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L40
       mov       rcx,2E0002088E4
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L41
M02_L40:
       lea       rcx,[rbp-68]
       mov       rdx,2E0002088D8
       call      qword ptr [7FFD1A4758F0]
M02_L41:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,[rbp-210]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L42
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-218]
       jmp       near ptr M02_L23
M02_L42:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-218]
       jmp       near ptr M02_L23
M02_L43:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L11
M02_L44:
       mov       rcx,r12
       mov       edx,1C
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L12
       mov       rcx,r12
       mov       edx,1C
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFD1A7542D0]
       mov       r13,rax
       mov       rcx,[rbp-220]
       mov       rax,[rbp-220]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,2E000208808
       mov       r8,2E0002088F0
       call      qword ptr [7FFD1A356B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L45
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L45:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L46:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L14
M02_L47:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A4758F0]
       jmp       near ptr M02_L15
M02_L48:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       cmp       byte ptr [rbp-54],0
       je        near ptr M02_L17
M02_L49:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475848]
       jmp       near ptr M02_L18
M02_L50:
       lea       rcx,[rbp-68]
       mov       rdx,2E0002088F0
       call      qword ptr [7FFD1A4758F0]
       jmp       near ptr M02_L19
M02_L51:
       call      qword ptr [7FFD1A4EE9D0]
       int       3
M02_L52:
       mov       rcx,r12
       call      qword ptr [7FFD1A51D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFD1A98EAC0]
       mov       r15,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A204000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFD1A35F750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L54:
       mov       rcx,[r12+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M02_L188
       mov       edx,r15d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-14C],eax
       jne       short M02_L55
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FFD1A51D7E8]
       mov       r10,rax
M02_L55:
       mov       r10,[r10+8]
       mov       [rbp-298],r10
       mov       rcx,7FFD1A295120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A295C38],0
       je        short M02_L56
       call      qword ptr [7FFD1A35DC98]
       mov       edx,eax
       mov       [rbp-168],edx
       jmp       short M02_L59
M02_L56:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-16C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-16C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L57
       call      qword ptr [7FFD1A9ACC18]
       mov       edx,eax
       jmp       short M02_L58
M02_L57:
       mov       edx,ecx
       sar       edx,10
M02_L58:
       mov       [rbp-168],edx
M02_L59:
       mov       rcx,7FFD1A295120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-168]
       xor       edx,edx
       div       dword ptr [7FFD1A295C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L66
M02_L60:
       cmp       eax,[r8+8]
       jae       near ptr M02_L188
       mov       [rbp-160],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-2A0],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-170],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-2A0]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-174],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L62
       test      r10d,r10d
       jne       short M02_L63
       xor       edx,edx
       mov       [rax+14],edx
M02_L61:
       movsxd    rdx,r10d
       mov       r8,[rbp-290]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-174]
       inc       ecx
       mov       rax,[rbp-2A0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-170],1
M02_L62:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-170]
       test      ecx,ecx
       je        short M02_L64
       mov       r8d,1
       jmp       short M02_L67
M02_L63:
       jmp       short M02_L61
M02_L64:
       mov       eax,[rbp-160]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-298]
       cmp       [rcx+8],r8d
       jne       short M02_L65
       xor       r8d,r8d
M02_L65:
       mov       edx,[rbp-164]
       inc       edx
       mov       eax,r8d
M02_L66:
       mov       r8,[rbp-298]
       mov       [rbp-164],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L60
       xor       r8d,r8d
M02_L67:
       mov       eax,r8d
       mov       [rbp-150],eax
       mov       eax,[rbp-14C]
       jmp       near ptr M02_L21
M02_L68:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rbp-150]
       cmp       dword ptr [r14+8],0
       mov       [rbp-14C],edx
       mov       [rbp-278],r8
       mov       [rbp-150],eax
       je        near ptr M02_L22
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-154],eax
       mov       edx,[r14+8]
       mov       [rbp-158],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-278]
       mov       r8d,[rbp-154]
       mov       r9d,[rbp-158]
       mov       edx,3
       call      qword ptr [7FFD1A407678]
       mov       eax,[rbp-14C]
       test      [rbp-150],eax
       mov       [rbp-14C],eax
       jne       near ptr M02_L22
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[r14+8]
       mov       rdx,[rbp-278]
       mov       [rbp-280],rdx
       mov       [rbp-15C],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-14C]
       test      r12d,r12d
       jne       short M02_L69
       mov       r15,[rbp-280]
       mov       edx,[rbp-15C]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L70
M02_L69:
       mov       rdx,[rbp-280]
       mov       ecx,[rbp-15C]
       mov       r8d,ecx
       mov       ecx,r15d
       mov       r15,rdx
       mov       edx,r8d
M02_L70:
       mov       r8d,r14d
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L71
       mov       eax,1
       jmp       short M02_L72
M02_L71:
       xor       eax,eax
M02_L72:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD1A51E2B0]
       jmp       near ptr M02_L22
M02_L73:
       mov       rcx,rdi
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L74:
       mov       rdx,2E000208A28
       cmp       r12,rdx
       jne       near ptr M02_L94
       mov       rdx,offset MT_System.Single
       cmp       [r13],rdx
       je        short M02_L75
       mov       rdx,r13
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD1A354408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M02_L75:
       vmovss    xmm0,dword ptr [r13+8]
       vmovss    dword ptr [rbp-6C],xmm0
       mov       rdx,[rbp-220]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L143
       mov       r12,[rbp-220]
       mov       rdx,[rbp-220]
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M02_L79
M02_L76:
       mov       rcx,2E00A800428
       mov       rcx,[rcx]
       vmovss    xmm0,dword ptr [rbp-6C]
       vmovss    dword ptr [rbp-19C],xmm0
       call      qword ptr [7FFD1A47F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovss    xmm0,dword ptr [rbp-19C]
       mov       rdx,2E000208A50
       call      qword ptr [7FFD1A49FA98]; System.Number.FormatSingle(Single, System.String, System.Globalization.NumberFormatInfo)
       mov       r12,rax
       test      r15,r15
       je        near ptr M02_L144
       cmp       dword ptr [r15+8],0
       je        near ptr M02_L144
       test      r12,r12
       je        near ptr M02_L145
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L145
       mov       ecx,[r15+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L149
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,2E000208814
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r14+r8*2+0C]
       mov       rcx,2E0002088FC
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r15+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r14+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
M02_L77:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L91
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L78:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rax,[rbp-50]
       mov       [rbp-1F8],rax
       mov       [rbp-1F0],ecx
       lea       rcx,[rbp-1F8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r13,r13
       je        short M02_L80
       jmp       near ptr M02_L98
M02_L79:
       vxorps    xmm1,xmm1,xmm1
       vmovups   [rbp-188],xmm1
       mov       rdx,[r12+48]
       lea       rcx,[rbp-188]
       call      qword ptr [7FFD1A546B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-188]
       vmovups   [rbp-198],xmm0
       lea       rcx,[rbp-198]
       call      qword ptr [7FFD1A546BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L76
M02_L80:
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L93
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L81:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,2E00A801EE8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFD1A529EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M02_L156
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L82:
       mov       [rbp-50],r8
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L157
       mov       rdx,2E000208814
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-58]
       inc       edx
       mov       [rbp-58],edx
       cmp       r14,r15
       jne       near ptr M02_L158
M02_L83:
       mov       r14,[rbp-220]
       mov       rdx,[rbp-220]
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M02_L90
M02_L84:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L159
M02_L85:
       test      r15,r15
       je        near ptr M02_L159
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L159
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-58]
       add       edx,[r15+8]
       mov       [rbp-58],edx
M02_L86:
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L160
       mov       rdx,2E00020887C
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-58]
       add       edx,3
       mov       [rbp-58],edx
M02_L87:
       mov       [rbp-0E0],r13
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L142
       mov       rdx,[rbp-0E0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A354348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L121
       mov       rdx,[rbp-0E0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A354348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L89
M02_L88:
       mov       rdx,[rbp-0E0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD1A3543C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rdx,[rbp-50]
       mov       r9d,ecx
       lea       r13,[rdx+r9*2]
       mov       r15d,[rbp-48]
       sub       r15d,ecx
       xor       ecx,ecx
       mov       rdx,offset MT_System.SByte
       cmp       [rax],rdx
       jne       near ptr M02_L102
       add       rax,8
       mov       rcx,[rbp-68]
       movsx     r14,byte ptr [rax]
       test      r14d,r14d
       jge       near ptr M02_L106
       jmp       near ptr M02_L125
M02_L89:
       mov       rdx,[rbp-0E0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD1A3543C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-68]
       mov       r11,7FFD1A2107C0
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L120
M02_L90:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFD1A546B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFD1A546BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L84
M02_L91:
       mov       rcx,rdi
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L92:
       xor       ecx,ecx
       mov       [rbp-0E8],rcx
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L51
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L166
       mov       rcx,2E000208814
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       near ptr M02_L78
M02_L93:
       mov       rcx,rdi
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L94:
       mov       rdx,2E000205740
       cmp       r12,rdx
       jne       near ptr M02_L112
       mov       rdx,offset MT_System.Double
       cmp       [r13],rdx
       je        short M02_L95
       mov       rdx,r13
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD1A354408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M02_L95:
       vmovsd    xmm0,qword ptr [r13+8]
       vmovsd    qword ptr [rbp-78],xmm0
       mov       rdx,[rbp-220]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L146
       mov       r12,[rbp-220]
       mov       rdx,[rbp-220]
       mov       r13,[rdx+8]
       test      r13,r13
       je        near ptr M02_L101
M02_L96:
       mov       rcx,2E00A800428
       mov       rcx,[rcx]
       vmovsd    xmm0,qword ptr [rbp-78]
       vmovsd    qword ptr [rbp-1C8],xmm0
       call      qword ptr [7FFD1A47F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovsd    xmm0,qword ptr [rbp-1C8]
       mov       rdx,2E000208A50
       call      qword ptr [7FFD1A49FA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r12,rax
       test      r13,r13
       je        near ptr M02_L147
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L147
       test      r12,r12
       je        near ptr M02_L148
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L148
       mov       ecx,[r13+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L149
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,2E000208814
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r13+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r14+r8*2+0C]
       mov       rcx,2E0002088FC
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r13+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r14+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
M02_L97:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L109
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L98:
       mov       r14,r12
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFD1A295120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L167
M02_L99:
       xor       eax,eax
       mov       dword ptr [rbp-100],1
       cmp       [rcx+8],r12d
       jbe       short M02_L100
       mov       dword ptr [rbp-0FC],1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [r13+8],edx
       jne       near ptr M02_L168
       mov       edx,r12d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-258],r10
       mov       r9,[r10]
       mov       [rbp-260],r9
       mov       rcx,r10
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       r10,[rbp-258]
       mov       [r10+8],ecx
       mov       rax,[rbp-260]
       test      rax,rax
       mov       [rbp-260],rax
       mov       eax,[rbp-0FC]
       jne       near ptr M02_L169
M02_L100:
       mov       rcx,2E00A8005D0
       mov       rdx,[rcx]
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M02_L183
       jmp       near ptr M02_L80
M02_L101:
       vxorps    xmm1,xmm1,xmm1
       vmovups   [rbp-1B0],xmm1
       mov       rdx,[r12+48]
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFD1A546B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-1B0]
       vmovups   [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFD1A546BE0]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L96
M02_L102:
       mov       rdx,rax
       mov       [rbp-208],r13
       mov       [rbp-200],r15d
       mov       [rbp-1F8],rcx
       xor       ecx,ecx
       mov       [rbp-1F0],ecx
       mov       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       rcx,rdx
       lea       rdx,[rbp-208]
       lea       r9,[rbp-1F8]
       lea       r8,[rbp-0F0]
       mov       r11,7FFD1A2107C8
       call      qword ptr [r11]
       mov       r14d,eax
M02_L103:
       test      r14d,r14d
       je        near ptr M02_L161
       mov       r8d,[rbp-58]
       add       r8d,[rbp-0F0]
       mov       [rbp-58],r8d
       jmp       near ptr M02_L92
M02_L104:
       xor       ecx,ecx
       mov       [rbp-0F8],rcx
M02_L105:
       jmp       short M02_L103
M02_L106:
       mov       ecx,r14d
       mov       edx,r14d
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       r9,7FFD792A87A0
       add       rcx,[r9+rdx*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        near ptr M02_L162
       mov       [rbp-0F0],ecx
       mov       [rbp-0F8],r13
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       cmp       r14d,0A
       jb        near ptr M02_L110
       cmp       r14d,64
       jb        short M02_L108
       mov       rdx,2E00A800290
       mov       rdx,[rdx]
M02_L107:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9d,r14d
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       r14d,r8d
       mov       r8,rdx
       shl       r14d,2
       mov       r11d,r14d
       mov       r8d,[r8+r11+10]
       mov       [rcx],r8d
       cmp       r9d,64
       mov       r14d,r9d
       jae       short M02_L107
M02_L108:
       cmp       r14d,0A
       jb        short M02_L110
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,2E00A800290
       mov       rdx,[rdx]
       lea       r9d,[r14*4]
       mov       edx,[rdx+r9+10]
       mov       [rcx],edx
       jmp       short M02_L111
M02_L109:
       mov       rcx,rdi
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L110:
       lea       edx,[r14+30]
       mov       [rcx-2],dx
M02_L111:
       xor       ecx,ecx
       mov       [rbp-0F8],rcx
       mov       r14d,1
       jmp       near ptr M02_L104
M02_L112:
       mov       rdx,2E000203C58
       cmp       r12,rdx
       jne       near ptr M02_L153
       mov       rdx,[rbp-220]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L151
       mov       r14,[rbp-220]
       mov       rdx,[rbp-220]
       mov       r12,[rdx+8]
       test      r12,r12
       je        near ptr M02_L122
M02_L113:
       mov       rax,offset MT_System.Boolean
       cmp       [r13],rax
       jne       near ptr M02_L152
       add       r13,8
       cmp       byte ptr [r13],0
       je        near ptr M02_L150
       mov       r14,2E000208AE0
M02_L114:
       cmp       [r14],r14b
       call      qword ptr [7FFD1A494180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M02_L116
       mov       rcx,rax
       call      qword ptr [7FFD1A46CFF8]; System.Globalization.CultureInfo.get_TextInfo()
M02_L115:
       mov       rcx,rax
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A49C1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       r9,rax
       mov       rdx,r12
       mov       rcx,2E000208808
       mov       r8,2E0002088F0
       call      qword ptr [7FFD1A356B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD1A4164B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M02_L23
M02_L116:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       short M02_L115
M02_L117:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,2E000208808
       mov       r8,2E000208820
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L118
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L118:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD1A40E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L119:
       mov       rdx,rcx
M02_L120:
       test      rdx,rdx
       je        near ptr M02_L92
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L51
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,r8d
       mov       r13d,[rdx+8]
       cmp       r13d,eax
       ja        near ptr M02_L165
       add       rdx,0C
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFD1A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp-58]
       mov       [rbp-58],r13d
       jmp       near ptr M02_L92
M02_L121:
       xor       r8d,r8d
       mov       [rbp-0E8],r8
       lea       r14,[rbp-0E0]
       cmp       qword ptr [rbp-0E8],0
       jne       short M02_L124
       jmp       short M02_L123
M02_L122:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-1D8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rbp-1D8]
       call      qword ptr [7FFD1A546B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-1D8]
       vmovups   [rbp-1E8],xmm0
       lea       rcx,[rbp-1E8]
       call      qword ptr [7FFD1A546BE0]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L113
M02_L123:
       mov       rcx,[r14]
       mov       [rbp-0E8],rcx
       lea       r14,[rbp-0E8]
       cmp       qword ptr [rbp-0E8],0
       je        near ptr M02_L163
M02_L124:
       mov       rcx,[r14]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L164
       jmp       near ptr M02_L119
M02_L125:
       test      rcx,rcx
       jne       short M02_L127
       call      qword ptr [7FFD1A47F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L126:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M02_L128
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M02_L129
M02_L127:
       call      qword ptr [7FFD1A47F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L126
M02_L128:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M02_L129:
       mov       ecx,r14d
       mov       [rbp-1F8],r8
       mov       [rbp-1F0],r9d
       mov       [rbp-208],r13
       mov       [rbp-200],r15d
       lea       r8,[rbp-0F0]
       mov       [rsp+20],r8
       lea       r8,[rbp-1F8]
       lea       r9,[rbp-208]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD1AA1FCC0]
       mov       r14d,eax
       jmp       near ptr M02_L105
M02_L130:
       mov       rcx,[r12+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-240],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rbp-240]
       mov       [rbp-90],rdx
       mov       [rbp-88],rax
       lea       rdx,[rbp-0B0]
       mov       [rsp+20],rdx
       mov       edx,[r12+50]
       lea       rcx,[rbp-90]
       lea       r8,[rbp-98]
       lea       r9,[rbp-0A0]
       call      qword ptr [7FFD1A5A57E8]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rbp-0A8]
       mov       [rbp-0B8],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-238],rax
       mov       r9,[r12+30]
       mov       rcx,rax
       mov       rdx,[rbp-0B8]
       mov       r8d,[rbp-0B0]
       call      qword ptr [7FFD1A547B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r12+38]
       mov       rdx,[rbp-238]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L131:
       mov       rcx,[rbp-220]
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       mov       r12,rax
       jmp       near ptr M02_L07
       call      CORINFO_HELP_OVERFLOW
M02_L132:
       mov       rcx,2E00A801F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L133:
       xor       ecx,ecx
       test      rcx,rcx
       jne       near ptr M02_L04
M02_L134:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD1A98C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A35F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L135:
       mov       rcx,[rbp-220]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r14+58]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M02_L05
M02_L136:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L08
M02_L137:
       mov       rdx,r12
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFD1A354360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L10
       mov       rcx,r12
       mov       rdx,2E000208890
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M02_L141
       mov       rcx,2E000208890
       call      qword ptr [7FFD1A2A4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M02_L138
       mov       rcx,r12
       mov       rdx,2E000208890
       call      qword ptr [7FFD1A2A6148]
       jmp       near ptr M02_L09
M02_L138:
       mov       rcx,2E000208890
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,2E000208890
       call      qword ptr [7FFD1A29A5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       r14,rax
       xor       r15d,r15d
       jmp       short M02_L140
M02_L139:
       mov       ecx,r15d
       mov       rcx,[r14+rcx*8+10]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       inc       r15d
M02_L140:
       cmp       [r14+8],r15d
       jg        short M02_L139
M02_L141:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       call      qword ptr [7FFD1A40DF98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-228],r12
       mov       rcx,[rbp-220]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-220]
       mov       r14,[rax]
       mov       rax,[r14+58]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD1A354348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L35
       mov       rcx,rax
       mov       r11,7FFD1A2107A0
       call      qword ptr [r11]
       mov       [rbp-230],rax
       jmp       near ptr M02_L26
M02_L142:
       lea       rcx,[rbp-68]
       mov       r8,[rbp-0E0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD1A9ACDE0]
       jmp       near ptr M02_L92
M02_L143:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       jmp       near ptr M02_L76
M02_L144:
       mov       r8,r12
       mov       rcx,2E000208808
       mov       rdx,2E0002088F0
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L145:
       mov       rdx,r15
       mov       rcx,2E000208808
       mov       r8,2E0002088F0
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L146:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M02_L96
M02_L147:
       mov       r8,r12
       mov       rcx,2E000208808
       mov       rdx,2E0002088F0
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L97
M02_L148:
       mov       rdx,r13
       mov       rcx,2E000208808
       mov       r8,2E0002088F0
       call      qword ptr [7FFD1A356B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L97
M02_L149:
       call      qword ptr [7FFD1A4EEF40]
       int       3
M02_L150:
       mov       r14,2E000208AC0
       jmp       near ptr M02_L114
M02_L151:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r12,rax
M02_L152:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M02_L114
M02_L153:
       mov       rdx,2E000208A68
       cmp       r12,rdx
       jne       near ptr M02_L154
       mov       rdx,r13
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD1A354408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rax,[rax]
       mov       [rbp-80],rax
       call      qword ptr [7FFD1A494270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       r8,rax
       lea       rcx,[rbp-80]
       mov       rdx,2E0002067B8
       call      qword ptr [7FFD1A61F048]
       mov       r13,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A475788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,[rbp-220]
       mov       rax,[rbp-220]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-68]
       mov       rdx,2E000208870
       call      qword ptr [7FFD1A475788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-68]
       mov       rdx,r13
       call      qword ptr [7FFD1A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       jmp       short M02_L155
M02_L154:
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD1A4756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A475788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,[rbp-220]
       mov       rax,[rbp-220]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-68]
       mov       rdx,2E000208870
       call      qword ptr [7FFD1A475788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-68]
       mov       r8,r13
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD1A5D6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M02_L155:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A475788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD1A4164B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M02_L23
M02_L156:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L82
M02_L157:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A4758F0]
       cmp       r14,r15
       je        near ptr M02_L83
M02_L158:
       mov       rcx,[rbp-220]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rbp-54],0
       je        near ptr M02_L85
M02_L159:
       lea       rcx,[rbp-68]
       mov       rdx,r15
       call      qword ptr [7FFD1A475848]
       jmp       near ptr M02_L86
M02_L160:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208870
       call      qword ptr [7FFD1A4758F0]
       jmp       near ptr M02_L87
M02_L161:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A475938]
       jmp       near ptr M02_L88
M02_L162:
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       xor       r14d,r14d
       jmp       near ptr M02_L104
M02_L163:
       xor       edx,edx
       jmp       near ptr M02_L120
M02_L164:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L119
M02_L165:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD1A4758F0]
       jmp       near ptr M02_L92
M02_L166:
       lea       rcx,[rbp-68]
       mov       rdx,2E000208808
       call      qword ptr [7FFD1A4758F0]
       jmp       near ptr M02_L78
M02_L167:
       mov       rcx,r14
       call      qword ptr [7FFD1A51D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L99
M02_L168:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFD1A98EAC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A204000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      qword ptr [7FFD1A35F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L169:
       mov       rcx,[r14+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L188
       mov       edx,r12d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-0FC],eax
       jne       short M02_L170
       mov       rcx,r14
       mov       edx,r12d
       call      qword ptr [7FFD1A51D7E8]
       mov       r10,rax
M02_L170:
       mov       r10,[r10+8]
       mov       [rbp-268],r10
       mov       rcx,7FFD1A295120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A295C38],0
       je        short M02_L171
       call      qword ptr [7FFD1A35DC98]
       mov       edx,eax
       mov       [rbp-118],edx
       jmp       short M02_L174
M02_L171:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-11C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-11C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L172
       call      qword ptr [7FFD1A9ACC18]
       mov       edx,eax
       jmp       short M02_L173
M02_L172:
       mov       edx,ecx
       sar       edx,10
M02_L173:
       mov       [rbp-118],edx
M02_L174:
       mov       rcx,7FFD1A295120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-118]
       xor       edx,edx
       div       dword ptr [7FFD1A295C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L181
M02_L175:
       cmp       eax,[r8+8]
       jae       near ptr M02_L188
       mov       [rbp-110],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-270],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-120],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-270]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-124],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L177
       test      r10d,r10d
       jne       short M02_L178
       xor       edx,edx
       mov       [rax+14],edx
M02_L176:
       movsxd    rdx,r10d
       mov       r8,[rbp-260]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-124]
       inc       ecx
       mov       rax,[rbp-270]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-120],1
M02_L177:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-120]
       test      ecx,ecx
       je        short M02_L179
       mov       r8d,1
       jmp       short M02_L182
M02_L178:
       jmp       short M02_L176
M02_L179:
       mov       eax,[rbp-110]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-268]
       cmp       [rcx+8],r8d
       jne       short M02_L180
       xor       r8d,r8d
M02_L180:
       mov       edx,[rbp-114]
       inc       edx
       mov       eax,r8d
M02_L181:
       mov       r8,[rbp-268]
       mov       [rbp-114],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L175
       xor       r8d,r8d
M02_L182:
       mov       eax,r8d
       mov       [rbp-100],eax
       mov       eax,[rbp-0FC]
       jmp       near ptr M02_L100
M02_L183:
       cmp       dword ptr [r13+8],0
       mov       [rbp-0FC],eax
       mov       [rbp-248],rdx
       je        near ptr M02_L80
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-104],eax
       mov       edx,[r13+8]
       mov       [rbp-108],edx
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-248]
       mov       r8d,[rbp-104]
       mov       r9d,[rbp-108]
       mov       edx,3
       call      qword ptr [7FFD1A407678]
       mov       eax,[rbp-0FC]
       test      [rbp-100],eax
       mov       [rbp-0FC],eax
       jne       near ptr M02_L80
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rbp-248]
       mov       [rbp-250],rdx
       mov       [rbp-10C],eax
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[rbp-0FC]
       test      r14d,r14d
       jne       short M02_L184
       mov       r12,[rbp-250]
       mov       edx,[rbp-10C]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L185
M02_L184:
       mov       rdx,[rbp-250]
       mov       ecx,[rbp-10C]
       mov       r8d,ecx
       mov       ecx,r12d
       mov       r12,rdx
       mov       edx,r8d
M02_L185:
       mov       r8d,r13d
       mov       r9d,eax
       test      r14d,r14d
       jne       short M02_L186
       mov       eax,1
       jmp       short M02_L187
M02_L186:
       xor       eax,eax
M02_L187:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r12
       call      qword ptr [7FFD1A51E2B0]
       jmp       near ptr M02_L80
M02_L188:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L189:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+2E0]
       mov       rdx,[rbp-230]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD1A354348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L190
       mov       rcx,rax
       mov       r11,7FFD1A2107B8
       call      qword ptr [r11]
M02_L190:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 9147
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M03_L01:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M03_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rbx],rdx
       jne       near ptr M03_L64
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+148]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD1A2A66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+158],0
       je        near ptr M03_L56
       cmp       dword ptr [rsp+158],1
       je        near ptr M03_L57
       mov       r14d,[rsp+158]
       test      r14d,r14d
       jl        near ptr M03_L58
       mov       r15,[rsp+148]
       test      r15,r15
       je        near ptr M03_L59
       cmp       [r15+8],r14d
       je        short M03_L03
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       lea       rcx,[r13+10]
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r14d,r8d
       cmovg     r14d,r8d
       mov       r8d,r14d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M03_L37
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M03_L02:
       mov       [rsp+148],r13
M03_L03:
       mov       ecx,[rsp+158]
       mov       [rsp+15C],ecx
       mov       r14,[rsp+148]
M03_L04:
       mov       rcx,2E00A804E90
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M03_L31
M03_L05:
       mov       rcx,2E00A804E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M03_L07
M03_L06:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD1A75F8A0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M03_L65
       mov       rcx,rbx
       jmp       near ptr M03_L39
M03_L07:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2E00A804E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A75B720
       mov       [r13+18],rcx
       mov       rcx,2E00A804E98
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L06
M03_L08:
       mov       r13d,1
       xor       r12d,r12d
       xor       ebx,ebx
       xor       eax,eax
       mov       [rsp+0C0],rax
       xor       r10d,r10d
       mov       [rsp+0B8],r10
M03_L09:
       mov       r9,rdi
       mov       r11d,ebp
       test      r11d,r11d
       je        near ptr M03_L68
       movzx     r8d,word ptr [r9]
       cmp       r8d,7B
       je        near ptr M03_L30
       cmp       r8d,7D
       je        near ptr M03_L27
       cmp       r8d,22
       je        near ptr M03_L20
       cmp       r8d,3A
       jne       near ptr M03_L13
       mov       ecx,9
M03_L10:
       mov       edx,ecx
       mov       [rsp+144],edx
       cmp       edx,6
       je        short M03_L11
       cmp       edx,7
       jne       near ptr M03_L38
M03_L11:
       cmp       edx,6
       jne       near ptr M03_L40
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+128],xmm0
       cmp       r11d,1
       jb        near ptr M03_L91
       add       r9,2
       sub       r11d,1
       mov       [rsp+60],r9
       mov       [rsp+0F4],r11d
       mov       edx,22
       mov       rcx,r9
       mov       r8d,r11d
       call      qword ptr [7FFD1A5D56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+13C],eax
       cmp       eax,[rsp+0F4]
       ja        near ptr M03_L91
       mov       rcx,[rsp+60]
       mov       [rsp+128],rcx
       mov       [rsp+130],eax
       lea       rcx,[rsp+128]
       call      qword ptr [7FFD1A40C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+58],rax
       mov       edx,[rsp+13C]
       add       edx,2
       mov       [rsp+0F0],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+68],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+0F0]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+68]
M03_L12:
       mov       r8,rax
       jmp       short M03_L15
M03_L13:
       cmp       r8d,2C
       jne       short M03_L16
       mov       ecx,8
       jmp       near ptr M03_L10
M03_L14:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+144]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
M03_L15:
       mov       rcx,r8
       mov       [rsp+0B0],rcx
       mov       r8d,[rcx+10]
       mov       [rsp+1E4],r8d
       mov       r9d,[rcx+14]
       mov       [rsp+1E0],r9d
       cmp       r8d,2
       je        near ptr M03_L55
       jmp       short M03_L18
M03_L16:
       cmp       r8d,5B
       je        near ptr M03_L60
       cmp       r8d,5D
       je        near ptr M03_L61
       cmp       r8d,20
       je        near ptr M03_L62
       cmp       r13d,9
       jne       near ptr M03_L63
M03_L17:
       mov       ecx,7
       jmp       near ptr M03_L10
M03_L18:
       cmp       r8d,8
       je        short M03_L21
       cmp       r8d,5
       jne       short M03_L19
       mov       r8d,[rsp+1E4]
       jmp       short M03_L21
M03_L19:
       mov       r8d,[rsp+1E4]
       jmp       near ptr M03_L29
M03_L20:
       cmp       r13d,9
       je        short M03_L17
       mov       ecx,6
       jmp       near ptr M03_L10
M03_L21:
       cmp       r13d,7
       jne       near ptr M03_L29
       test      rbx,rbx
       je        near ptr M03_L29
       cmp       dword ptr [rbx+10],6
       jne       near ptr M03_L29
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        near ptr M03_L29
       mov       rax,[rsp+0C0]
       test      rax,rax
       je        short M03_L26
       mov       [rsp+0C0],rax
       cmp       dword ptr [rax+10],9
       jne       near ptr M03_L29
       mov       r10,[rsp+0B8]
       test      r10,r10
       je        short M03_L25
       cmp       dword ptr [r10+10],7
       jne       short M03_L24
       mov       [rsp+0B8],r10
       movzx     r11d,byte ptr [r10+18]
M03_L22:
       test      r11d,r11d
       je        short M03_L29
       mov       r11,rdx
       test      r11,r11
       je        short M03_L23
       jmp       near ptr M03_L47
M03_L23:
       jmp       near ptr M03_L48
M03_L24:
       mov       rax,[rsp+0C0]
       jmp       near ptr M03_L46
M03_L25:
       mov       rax,[rsp+0C0]
       jmp       near ptr M03_L46
M03_L26:
       mov       [rsp+0C0],rax
       jmp       short M03_L29
M03_L27:
       mov       ecx,5
       jmp       near ptr M03_L10
M03_L28:
       mov       rdx,r15
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFD1A75F888]; Ferris.Json.Libs.MapValue(System.Reflection.PropertyInfo, System.Object, Ferris.Json.TokenInfo)
       mov       r8d,[rsp+1E4]
M03_L29:
       cmp       r8d,4
       jne       short M03_L32
       jmp       near ptr M03_L53
M03_L30:
       mov       ecx,4
       jmp       near ptr M03_L10
M03_L31:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2E00A804E88
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD1A75B708
       mov       [r15+18],rcx
       mov       rcx,2E00A804E90
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L05
M03_L32:
       cmp       r8d,0A
       je        near ptr M03_L76
M03_L33:
       cmp       r8d,5
       je        near ptr M03_L52
       cmp       r8d,8
       je        short M03_L35
       cmp       r8d,3
       je        short M03_L35
       cmp       r8d,6
       je        short M03_L34
       cmp       r8d,9
       jne       near ptr M03_L44
       jmp       near ptr M03_L51
M03_L34:
       mov       rcx,[rsp+0B0]
       mov       rbx,rcx
M03_L35:
       cmp       r8d,3
       je        short M03_L36
       mov       r13d,r8d
M03_L36:
       mov       r9d,[rsp+1E0]
       cmp       r9d,ebp
       ja        near ptr M03_L91
       mov       ecx,r9d
       lea       rdi,[rdi+rcx*2]
       sub       ebp,r9d
       jmp       near ptr M03_L09
M03_L37:
       call      qword ptr [7FFD1A405BD8]
       jmp       near ptr M03_L02
M03_L38:
       cmp       edx,3
       je        near ptr M03_L72
       jmp       near ptr M03_L14
M03_L39:
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M03_L66
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A2A6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r15,rax
       test      r15,r15
       je        near ptr M03_L67
       jmp       near ptr M03_L08
M03_L40:
       cmp       edx,7
       jne       near ptr M03_L71
       test      r11d,r11d
       je        near ptr M03_L92
       movzx     r8d,word ptr [r9]
       cmp       r8d,22
       je        near ptr M03_L45
       mov       [rsp+40],r9
       mov       [rsp+0E4],r11d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       mov       edx,2C
       mov       rcx,r9
       mov       r8d,r11d
       call      qword ptr [7FFD1A5D56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+10C],eax
       mov       edx,7D
       mov       rcx,[rsp+40]
       mov       r8d,[rsp+0E4]
       call      qword ptr [7FFD1A5D56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       edx,[rsp+10C]
       test      edx,edx
       jl        near ptr M03_L43
       test      eax,eax
       jl        near ptr M03_L69
       cmp       edx,eax
       jg        near ptr M03_L70
       mov       r8d,edx
M03_L41:
       mov       eax,r8d
M03_L42:
       cmp       eax,[rsp+0E4]
       ja        near ptr M03_L91
       mov       rcx,[rsp+40]
       mov       [rsp+108],eax
       mov       edx,eax
       mov       [rsp+0F8],rcx
       mov       [rsp+100],edx
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFD1A40C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+38],rax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+78],rax
       mov       dword ptr [rax+10],7
       mov       r8d,[rsp+108]
       mov       [rax+14],r8d
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+78]
       jmp       near ptr M03_L12
M03_L43:
       mov       r8d,eax
       mov       eax,r8d
       jmp       near ptr M03_L42
M03_L44:
       cmp       r8d,7
       jne       near ptr M03_L54
       jmp       near ptr M03_L50
M03_L45:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       cmp       r11d,1
       jb        near ptr M03_L91
       add       r9,2
       sub       r11d,1
       mov       [rsp+50],r9
       mov       [rsp+0EC],r11d
       mov       edx,22
       mov       rcx,r9
       mov       r8d,r11d
       call      qword ptr [7FFD1A5D56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+124],eax
       cmp       eax,[rsp+0EC]
       ja        near ptr M03_L91
       mov       rcx,[rsp+50]
       mov       [rsp+110],rcx
       mov       [rsp+118],eax
       lea       rcx,[rsp+110]
       call      qword ptr [7FFD1A40C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+48],rax
       mov       edx,[rsp+124]
       add       edx,2
       mov       [rsp+0E8],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+70],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+0E8]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+70]
       jmp       near ptr M03_L12
M03_L46:
       xor       r11d,r11d
       mov       [rsp+0B8],r10
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L22
M03_L47:
       mov       [rsp+0C8],rbx
       mov       rbx,offset MT_System.String
       cmp       [r11],rbx
       jne       near ptr M03_L88
       mov       rbx,[rsp+0C8]
M03_L48:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,r11
       call      qword ptr [7FFD1A35EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L49
       mov       rcx,[rax]
       jmp       near ptr M03_L28
M03_L49:
       mov       r8d,[rsp+1E4]
       jmp       near ptr M03_L29
M03_L50:
       mov       rcx,[rsp+0B0]
       mov       r10,rcx
       mov       [rsp+0B8],r10
       jmp       near ptr M03_L35
M03_L51:
       mov       rcx,[rsp+0B0]
       mov       [rsp+0C0],rcx
       jmp       near ptr M03_L35
M03_L52:
       mov       r9d,[rsp+1E0]
       cmp       r9d,ebp
       ja        near ptr M03_L91
       mov       eax,r9d
       lea       rdi,[rdi+rax*2]
       sub       ebp,r9d
       jmp       short M03_L55
M03_L53:
       cmp       r13d,9
       je        near ptr M03_L73
       jmp       near ptr M03_L32
M03_L54:
       cmp       r8d,4
       jne       near ptr M03_L35
       test      r12,r12
       jne       near ptr M03_L35
       mov       rcx,[rsp+0B0]
       mov       r12,rcx
       jmp       near ptr M03_L35
M03_L55:
       mov       rcx,rsi
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,1E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L56:
       mov       rcx,2E00A801F30
       mov       r14,[rcx]
       jmp       near ptr M03_L04
M03_L57:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,[rsp+150]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L04
M03_L58:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD1A4EED48]
       int       3
M03_L59:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+148],rax
       jmp       near ptr M03_L03
M03_L60:
       mov       rax,[rsp+0C0]
       mov       ecx,0A
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L10
M03_L61:
       mov       rax,[rsp+0C0]
       mov       ecx,0B
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L10
M03_L62:
       mov       rax,[rsp+0C0]
       mov       ecx,3
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L10
M03_L63:
       mov       rax,[rsp+0C0]
       xor       ecx,ecx
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L10
M03_L64:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M03_L04
M03_L65:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L39
M03_L66:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD1A98CE58]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD1A204000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD1A35F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       [rsp+168],rdi
       mov       [rsp+170],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+160]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+170]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,1E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L68:
       mov       rax,[rsp+0C0]
       mov       ecx,2
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L10
M03_L69:
       mov       rax,[rsp+0C0]
       mov       ecx,edx
       mov       [rsp+0C0],rax
       mov       eax,ecx
       jmp       near ptr M03_L42
M03_L70:
       mov       r8d,eax
       jmp       near ptr M03_L41
M03_L71:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+144]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M03_L12
M03_L72:
       mov       [rsp+0D0],r9
       mov       [rsp+0D8],r11d
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD1A7543D8]
       mov       [rsp+140],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rsp+80],r8
       mov       rcx,r8
       mov       edx,3
       mov       r8d,[rsp+140]
       call      qword ptr [7FFD1A75F648]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r8,[rsp+80]
       mov       rcx,r8
       mov       r8,rcx
       jmp       near ptr M03_L15
M03_L73:
       mov       rax,[rsp+0C0]
       mov       rcx,rbx
       mov       [rsp+0C0],rax
       mov       rdx,rax
       call      qword ptr [7FFD1A754360]
       test      eax,eax
       mov       r8d,[rsp+1E4]
       je        near ptr M03_L35
       mov       rax,[rsp+0C0]
       mov       rdx,[rbx+8]
       mov       r11,rdx
       test      r11,r11
       je        near ptr M03_L75
       mov       rcx,offset MT_System.String
       cmp       [r11],rcx
       mov       [rsp+0C0],rax
       jne       near ptr M03_L89
M03_L74:
       lea       r8,[rsp+1D8]
       mov       rcx,r14
       mov       rdx,r11
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A3E4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+1E4]
       je        near ptr M03_L35
       mov       rcx,[rsp+1D8]
       mov       rdx,[rsp+1D8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+0D0],rdi
       mov       [rsp+0D8],ebp
       lea       r8,[rsp+0D0]
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFD1A754390]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+10],7
       xor       ecx,ecx
       mov       [r13+14],ecx
       mov       byte ptr [r13+18],0
       mov       byte ptr [r13+18],1
       lea       rcx,[r13+8]
       mov       rdx,[rsp+1C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+0B8],r13
       mov       ebp,7
       mov       rdi,[rsp+1C8]
       mov       ecx,[rsp+1D0]
       mov       eax,ecx
       mov       r13d,ebp
       mov       ebp,eax
       jmp       near ptr M03_L09
M03_L75:
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L74
M03_L76:
       mov       rax,[rsp+0C0]
       cmp       r13d,9
       jne       near ptr M03_L83
       mov       rcx,rbx
       mov       [rsp+0C0],rax
       mov       rdx,rax
       call      qword ptr [7FFD1A754360]
       test      eax,eax
       mov       r8d,[rsp+1E4]
       je        near ptr M03_L35
       mov       rdx,[rbx+8]
       mov       r11,rdx
       test      r11,r11
       je        near ptr M03_L82
       mov       rcx,offset MT_System.String
       cmp       [r11],rcx
       jne       near ptr M03_L90
M03_L77:
       lea       r8,[rsp+1B8]
       mov       rcx,r14
       mov       rdx,r11
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A3E4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L81
       mov       rcx,[rsp+1B8]
       mov       rdx,[rsp+1B8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       [rsp+0A8],rax
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       test      eax,eax
       je        near ptr M03_L84
       mov       rcx,[rsp+0A8]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       rcx,2E000208BA0
       cmp       rax,rcx
       jne       near ptr M03_L84
       mov       rcx,[rsp+0A8]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L92
       mov       r13,[rax+10]
       mov       rcx,[rsp+0A8]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A516028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3543C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0A0],rax
M03_L78:
       cmp       ebp,1
       jb        near ptr M03_L91
       add       rdi,2
       lea       edx,[rbp-1]
       mov       [rsp+0D0],rdi
       mov       [rsp+0D8],edx
       mov       rdx,r13
       lea       r8,[rsp+0D0]
       lea       rcx,[rsp+198]
       call      qword ptr [7FFD1A754390]
       mov       rdi,[rsp+1A0]
       mov       ebp,[rsp+1A8]
       mov       [rsp+0D0],rdi
       mov       [rsp+0D8],ebp
       lea       rdx,[rsp+0D0]
       mov       ecx,1
       call      qword ptr [7FFD1A754450]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+1B4],eax
       mov       rcx,[rsp+0A0]
       mov       rdx,[rsp+198]
       mov       r11,7FFD1A210708
       call      qword ptr [r11]
       mov       ecx,[rsp+1B4]
       cmp       ecx,8
       je        near ptr M03_L78
       cmp       ecx,0B
       jne       short M03_L79
       cmp       ebp,1
       jb        near ptr M03_L91
       add       rdi,2
       dec       ebp
M03_L79:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+10],7
       xor       ecx,ecx
       mov       [r13+14],ecx
       mov       byte ptr [r13+18],0
       mov       byte ptr [r13+18],1
       lea       rcx,[r13+8]
       mov       rdx,[rsp+0A0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L80:
       mov       eax,7
       mov       [rsp+0B8],r13
       mov       r13d,eax
       jmp       near ptr M03_L09
M03_L81:
       mov       r8d,[rsp+1E4]
       jmp       near ptr M03_L35
M03_L82:
       jmp       near ptr M03_L77
M03_L83:
       mov       [rsp+0C0],rax
       jmp       near ptr M03_L33
M03_L84:
       mov       rcx,[rsp+0A8]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M03_L87
       mov       rcx,[rsp+0A8]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r13,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+90],rax
       lea       rcx,[rax+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+90]
       mov       rcx,2E000208BA0
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A29A758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD1A516028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD1A3543C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+98],rax
M03_L85:
       cmp       ebp,1
       jb        near ptr M03_L91
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       rdx,r13
       lea       r8,[rsp+0D0]
       lea       rcx,[rsp+178]
       call      qword ptr [7FFD1A754390]
       mov       rdi,[rsp+180]
       mov       ebp,[rsp+188]
       mov       [rsp+0D0],rdi
       mov       [rsp+0D8],ebp
       lea       rdx,[rsp+0D0]
       mov       ecx,1
       call      qword ptr [7FFD1A754450]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+194],eax
       mov       rcx,[rsp+98]
       mov       rdx,[rsp+178]
       mov       r11,7FFD1A2106F0
       call      qword ptr [r11]
       mov       ecx,[rsp+194]
       cmp       ecx,8
       je        near ptr M03_L85
       mov       rax,[rsp+98]
       cmp       ecx,0B
       jne       short M03_L86
       cmp       ebp,1
       jb        near ptr M03_L91
       add       rdi,2
       dec       ebp
M03_L86:
       mov       rcx,rax
       mov       r11,7FFD1A2106F8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r13
       call      qword ptr [7FFD1A2A7678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r13,rax
       mov       rcx,[rsp+98]
       mov       rdx,r13
       mov       r11,7FFD1A210700
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       dword ptr [rax+10],7
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+88]
       jmp       near ptr M03_L80
M03_L87:
       mov       rcx,[rsp+0A8]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r8d,[rsp+1E4]
       jmp       near ptr M03_L35
M03_L88:
       mov       rcx,rbx
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L89:
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L90:
       call      qword ptr [7FFD1A3543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L91:
       call      qword ptr [7FFD1A4EE9D0]
       int       3
M03_L92:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 4327
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD1A354348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M04_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M04_L05
M04_L00:
       mov       rax,rbx
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD1A204000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A5166E8]
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M04_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD1A9A43F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD1A7CCF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD1A9A4480]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD1A7CCF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L06:
       mov       rcx,2E000203C58
       cmp       rsi,rcx
       jne       short M04_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210798
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,2E000208848
       cmp       rsi,rcx
       jne       short M04_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210790
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,2E0002089B0
       cmp       rsi,rcx
       jne       short M04_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210788
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L09:
       mov       rcx,2E000208988
       cmp       rsi,rcx
       jne       short M04_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210780
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,2E000208910
       cmp       rsi,rcx
       jne       short M04_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210778
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L11:
       mov       rcx,2E000208610
       cmp       rsi,rcx
       jne       short M04_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210770
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L12:
       mov       rcx,2E000204FE8
       cmp       rsi,rcx
       jne       short M04_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210768
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,2E000208938
       cmp       rsi,rcx
       jne       short M04_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210760
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,2E000205F80
       cmp       rsi,rcx
       jne       short M04_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210758
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,2E000208960
       cmp       rsi,rcx
       jne       short M04_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210750
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,2E000208A28
       cmp       rsi,rcx
       jne       short M04_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210748
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L17:
       mov       rcx,2E000205740
       cmp       rsi,rcx
       jne       short M04_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210740
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,2E0002089D8
       cmp       rsi,rcx
       jne       short M04_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD1A210738
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,2E000208A68
       cmp       rsi,rcx
       jne       short M04_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210730
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L20:
       mov       rcx,2E000200020
       cmp       rsi,rcx
       jne       short M04_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD1A210728
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L21:
       mov       rcx,2E0002021B8
       cmp       rsi,rcx
       je        near ptr M04_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD1A210720
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
M05_L03:
       jmp       qword ptr [7FFD1A3543A8]
; Total bytes of code 69
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M06_L03
       cmp       r8,4
       jae       short M06_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L00:
       test      r8b,1
       je        short M06_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M06_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L03:
       cmp       rcx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L04:
       vzeroupper
       ret
M06_L05:
       mov       eax,1
       vzeroupper
       ret
M06_L06:
       cmp       r8,20
       jb        short M06_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L08
M06_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
       add       rax,20
       cmp       r8,rax
       ja        short M06_L07
M06_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M06_L13
       nop       dword ptr [rax]
       jmp       short M06_L05
       nop       dword ptr [rax]
M06_L09:
       cmp       r8,10
       jb        short M06_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L11
M06_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L13
       add       rax,10
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L13
       jmp       near ptr M06_L05
M06_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L04
M06_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD79CF41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD79D07B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD79D08B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftValueMapping()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,1F3620041A0
       mov       rsi,[rcx]
       mov       rcx,1F362004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L07
       xor       edi,edi
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFD1A746DC0]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rdi,rdi
       jne       near ptr M00_L08
M00_L01:
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       call      qword ptr [7FFD1A7446D8]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,1F3002090D0
       xor       r8d,r8d
       call      qword ptr [7FFD1A7447C8]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.ValueTestObject
       cmp       [rdi],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       mov       r8,1F3620041A0
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rdi,rdi
       je        short M00_L05
       mov       rdx,[rdi+8]
M00_L03:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L04
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A3F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L06
M00_L04:
       inc       dword ptr [rbx+8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       xor       edx,edx
       jmp       short M00_L03
M00_L06:
       dec       dword ptr [rbx+8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFD1A746E38]
       jmp       near ptr M00_L01
; Total bytes of code 284
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,1F362004ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,1F3620050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F362004ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F3620050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1F362000428
       mov       r13,[rcx]
       mov       rcx,1F3620014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F300201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,1F362005078
       mov       rax,1F362005080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A73AC90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A3FD458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD1A58A130]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD1A74F540]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD1A2011E0
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,1F362004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD1A746DC0]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD1A7719C0]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD1A73AC90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD1A506640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD1A746E38]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD1A746E38]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD1A201010
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD1A201018
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD79D0B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M05_L03
       cmp       r8,4
       jae       short M05_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L00:
       test      r8b,1
       je        short M05_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M05_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L03:
       cmp       rcx,rdx
       je        short M05_L05
       jmp       short M05_L06
M05_L04:
       vzeroupper
       ret
M05_L05:
       mov       eax,1
       vzeroupper
       ret
M05_L06:
       cmp       r8,20
       jb        short M05_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L08
M05_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L13
       add       rax,20
       cmp       r8,rax
       ja        short M05_L07
M05_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       nop       dword ptr [rax]
       jmp       short M05_L05
       nop       dword ptr [rax]
M05_L09:
       cmp       r8,10
       jb        short M05_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L11
M05_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L13
       add       rax,10
       cmp       r8,rax
       ja        short M05_L10
M05_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L13
       jmp       near ptr M05_L05
M05_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L04
M05_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.TextJsonValueMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,21F3B4041A0
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,21F3B404F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L16
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L17
       mov       rdx,[rdi+0B8]
       mov       r8,21F002087E0
       cmp       rdx,r8
       jne       near ptr M00_L17
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L09
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFD1A7470C0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L10
       mov       rdx,21F3B404F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L11
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L12
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L18
       mov       rdx,[r15+0B8]
       mov       r8,21F002087E0
       cmp       rdx,r8
       jne       near ptr M00_L18
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFD1A957C90]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       r8,21F3B4041A0
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rax,rax
       je        near ptr M00_L13
       mov       rdx,[rax+8]
M00_L07:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L08
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L14
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD1A3F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L14
M00_L08:
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       mov       ecx,389E
       mov       rdx,7FFD1A73AC98
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A74C018]
       int       3
M00_L11:
       mov       rcx,21F3B404F48
       xor       edx,edx
       call      qword ptr [7FFD1A745BA8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,r14
       call      qword ptr [7FFD1A745B00]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L13:
       xor       edx,edx
       jmp       near ptr M00_L07
M00_L14:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L15:
       mov       rcx,21F3B404F48
       xor       edx,edx
       call      qword ptr [7FFD1A745BA8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFD1A745B00]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L17:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,21F002087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7453B0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L18:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,21F002087E0
       mov       r8d,1
       call      qword ptr [7FFD1A7453B0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L19:
       call      qword ptr [7FFD1A3443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 714
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A745B78]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,21F3B402000
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD1A923678]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,21F00201C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD1A746E80]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       cmp       r15d,r12d
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFD1A4DE9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD1A74D908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD1A917BB8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFD1A73C7A8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21F3B404F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD1A915128]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD1A9176C0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD1A9152A8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFD1A4DE9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD1A3F5BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,21F3B402000
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD1A923680]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,55FCBCB416CC
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+28],rcx
       cmp       edi,55
       jle       near ptr M02_L11
       cmp       edi,15555555
       ja        short M02_L04
       mov       rdx,21F3B402000
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFD1A923678]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
M02_L01:
       test      rax,rax
       je        near ptr M02_L12
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M02_L02:
       mov       rax,r15
M02_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       jmp       short M02_L05
M02_L04:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFD1A74D950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L01
M02_L05:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFD1A74D968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        short M02_L08
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L07
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L06
       jmp       short M02_L09
M02_L06:
       mov       ecx,347F
       mov       rdx,7FFD1A73AC98
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A74C078]
       int       3
M02_L07:
       mov       ecx,347F
       mov       rdx,7FFD1A73AC98
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD1A74C0C0]
       int       3
M02_L08:
       call      qword ptr [7FFD1A4DE9D0]
       int       3
M02_L09:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFD1A95CBD0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD1A95DC80]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A805938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rcx,[rbp+78]
       xor       edx,edx
       mov       [rbp+78],rdx
       mov       [rbp+20],rcx
       mov       rcx,[rbp]
       call      M02_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,55FCBCB416CC
       cmp       [rbp+8],rcx
       je        short M02_L10
       call      CORINFO_HELP_FAIL_FAST
M02_L10:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M02_L03
M02_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M02_L02
M02_L13:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M02_L37
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M02_L15
       cmp       rdx,300
       ja        short M02_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFD1A3F5BA8]
M02_L15:
       mov       rcx,21F3B402000
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFD1A285120
       mov       edx,36
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L16
       mov       rcx,r14
       call      qword ptr [7FFD1A917C48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M02_L32
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M02_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFD1A79D2D8]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFD1A1F4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFD1A34F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       r15,[rcx+rdx+10]
       mov       rsi,[r15]
       mov       rdx,[rbp+28]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],eax
       test      rsi,rsi
       je        near ptr M02_L32
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M02_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFD1A917BD0]
M02_L18:
       mov       rbx,[rax+8]
       mov       rcx,7FFD1A285120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD1A285C38],0
       je        short M02_L20
       call      qword ptr [7FFD1A34DC98]
       mov       edi,eax
       jmp       short M02_L23
M02_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L20:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M02_L21
       call      qword ptr [7FFD1AAE7870]
       jmp       short M02_L22
M02_L21:
       mov       eax,edi
       sar       eax,10
M02_L22:
       mov       edi,eax
M02_L23:
       mov       rcx,7FFD1A285120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFD1A285C2C]
       mov       edi,edx
       xor       r15d,r15d
       jmp       near ptr M02_L30
M02_L24:
       cmp       edi,[rbx+8]
       jae       short M02_L19
       mov       ecx,edi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L26
       test      r10d,r10d
       jne       short M02_L27
       xor       edx,edx
       mov       [rax+14],edx
M02_L25:
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M02_L26:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M02_L28
       mov       ecx,1
       jmp       short M02_L31
M02_L27:
       jmp       short M02_L25
M02_L28:
       inc       edi
       cmp       [rbx+8],edi
       jne       short M02_L29
       xor       edi,edi
M02_L29:
       inc       r15d
M02_L30:
       cmp       [rbx+8],r15d
       jg        near ptr M02_L24
       xor       ecx,ecx
M02_L31:
       mov       ebx,ecx
M02_L32:
       mov       rax,21F3B4005D0
       mov       r15,[rax]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,esi
       mov       r9d,edi
       mov       edx,3
       call      qword ptr [7FFD1A3F7678]
       test      ebx,r12d
       jne       short M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       esi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M02_L33
       mov       ecx,0FFFFFFFF
       jmp       short M02_L34
M02_L33:
       mov       ecx,r13d
M02_L34:
       mov       edx,ebx
       mov       r8d,esi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L35
       mov       eax,1
       jmp       short M02_L36
M02_L35:
       xor       eax,eax
M02_L36:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD1A50E2B0]
M02_L37:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1600
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M03_L03
       cmp       r8,4
       jae       short M03_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M03_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M03_L00:
       test      r8b,1
       je        short M03_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L03:
       cmp       rcx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L04:
       vzeroupper
       ret
M03_L05:
       mov       eax,1
       vzeroupper
       ret
M03_L06:
       cmp       r8,20
       jb        short M03_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M03_L08
M03_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M03_L13
       add       rax,20
       cmp       r8,rax
       ja        short M03_L07
M03_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       nop       dword ptr [rax]
       jmp       short M03_L05
       nop       dword ptr [rax]
M03_L09:
       cmp       r8,10
       jb        short M03_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M03_L11
M03_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M03_L13
       add       rax,10
       cmp       r8,rax
       ja        short M03_L10
M03_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M03_L13
       jmp       near ptr M03_L05
M03_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L04
M03_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD79D0B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD1A745530]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD1A7447C8]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD1A7477E0]
       mov       [rbp-40],rax
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFD1A7476D8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M05_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A745590]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD1A747768]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M05_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M05_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M06_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M06_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M06_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD1A7447C8]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M06_L05
       call      qword ptr [7FFD1A7476D8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD1A344360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M06_L03
       jmp       near ptr M06_L09
M06_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L09
M06_L03:
       call      qword ptr [7FFD1A7478E8]
       test      eax,eax
       je        near ptr M06_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD1A804450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD1A804450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD1A804480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD1A7477B0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M06_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A804318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A804318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A804318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A745B00]
       jmp       short M06_L09
M06_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A804390]
       jmp       short M06_L09
M06_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD1A344360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L07
M06_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M06_L08
M06_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M06_L08:
       cmp       dword ptr [rbp-34],0
       je        short M06_L09
       call      qword ptr [7FFD1A74C978]
M06_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A745AB8]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M07_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A745368]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD1A804360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       cmp       qword ptr [rbp-8],0
       je        short M07_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD1A746790]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M07_L01
M07_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD1A745B18]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M07_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M07_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD1A604720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M07_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD1A745578]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD1A74CF60]
M07_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

